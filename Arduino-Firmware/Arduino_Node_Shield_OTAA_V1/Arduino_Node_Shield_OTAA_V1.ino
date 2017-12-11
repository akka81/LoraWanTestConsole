/*
 ***********************************************************************
   NOTE:
   Frequency is defined in config.h file inside the src folder of this
   library. Edit this file to select the frequency that fit your region.
 ***********************************************************************

*/

#include "LoRaNode.h"

// Application's keys
const char * appEui = "00D1AB23BA45F04F";
const char * appKey = "000004F1FA66D52F4DB0B853D7BB5F3C";
const char * devEui = "00C1400992701D4C";

// define pinout schema
#define led 6
#define light_sensor 2
#define buzzer 5

// define global variables
int global_light_value = 0;
int global_delta_value = 100;

void setup() {
  // pin initialization
  pinoutInit();

  // USB serial communication
  Serial.begin(9600);

  // OTAA LoRa network connection
  node.joinOTAA(appEui, appKey, devEui);

  //register callback for incoming messages
  node.onReceive(readMsg);

  //show the node's main parameters
  node.showStatus();

  Serial.println("joining...");

  //begin initialization and attempt join
  node.begin();

  Serial.println("joined!");
}

void loop() {
  // send light message
  sendLightValue();

  //wait 1 seconds sleeping to save power
  node.sleep(1000);
}

void readMsg(unsigned char * rcvData, int dim, int port) {
  Serial.print("data = ");
  for (int i = 0; i < dim; i++)  Serial.print(rcvData[i], HEX);
  Serial.println();
  Serial.println("on port " + String(port));
  int rcv_delta_value = 0;
  switch (port) {
    case 4:
      sendLightValue();
      break;
    case 3:
      rcv_delta_value = rcvData[0];
      if (rcv_delta_value > 0) global_delta_value = rcv_delta_value;
      break;
    case 2:
      switch (rcvData[0]) {
        case 0: triggerLed(); break;
        case 1: turnOnLed(); break;
        case 2: turnOffLed(); break;
      }
      break;
    case 1:
      triggerBuzzer();
      break;
  }
}

void sendMessageIfLightValueChanged() {
  int current_light_value = analogRead(light_sensor);
  int global_max_light_value = global_light_value + (global_delta_value / 2);
  int global_min_light_value = global_light_value - (global_delta_value / 2);
  if ((current_light_value > global_max_light_value) | (current_light_value < global_min_light_value)) {
    global_light_value = current_light_value;
    char msg_light_value[] = {global_light_value, global_delta_value};
    node.sendFrame(msg_light_value, sizeof(msg_light_value), 2);
    Serial.println("Send Light Value: " + String(global_light_value));
  }
}

void sendLightValue() {
  int current_light_value = analogRead(light_sensor);
  char msg_light_value[] = {current_light_value};
  node.sendFrame(msg_light_value, sizeof(msg_light_value), 4);
}

void turnOnLed() {
  digitalWrite(led, HIGH);
}

void turnOffLed() {
  digitalWrite(led, LOW);
}

void triggerLed() {
  digitalWrite(led, HIGH);
  delay(100);
  digitalWrite(led, LOW);
}

void triggerBuzzer() {
  tone(buzzer, 600, 1000);
}

void pinoutInit() {
  // pin mode output for led and buzzer
  // pin mode input for light_sensor
  pinMode(led, OUTPUT);
  pinMode(light_sensor, INPUT);
  pinMode(buzzer, OUTPUT);
  // turn off led
  digitalWrite(led, LOW);
}

