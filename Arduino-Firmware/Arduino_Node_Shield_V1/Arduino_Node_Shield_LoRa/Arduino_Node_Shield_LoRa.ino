// Application's keys
const char * deviceAddress         = "00000001";
const char * networkSessionKey     = "A04F160D023944B88F56534361C138E6";
const char * applicationSessionKey = "FE5EFBC8A5FA4FF4A946674D68CB7E9D";

#include "LoRaNode.h"

// pinout board
#define led 6
#define lightSensor 2
#define buzzer 5

void setup() {
  // inizializzazione pinout
  pinoutInit();

  //  inizio connessione seriale
  Serial.begin(9600);

  // registrazione delle chiavi
  node.joinABP(deviceAddress, networkSessionKey, applicationSessionKey);
  // callback della ricezione di un messaggio
  node.onReceive(readMsg);
  //  inizializzazione
  node.begin();
  //  mostra parametri connessione
  node.showStatus();
}

void loop() {
  readAndSendLightValue();
  Serial.println("Send Message");
  delay(5000);
}

// lettura del messaggio da rete LoRa
void readMsg(unsigned char * rcvData, int dim, int port) {
  // print message received
  Serial.println("Message Received");
  Serial.print("Command: ");
  Serial.println(rcvData[0], HEX);
  Serial.println("on port " + String(port) + "\r\n");

  int command = rcvData[0];
  // do command received
  actuateCommand(port, command);
}

void actuateCommand(int port, int command) {
  // port:    2 = LED; 3 = LIGHT_SENSOR; 4 = BUZZER
  // command: 0 = enable; 1 = disable; 2 = read
  switch (port) {
    // LED_COMMANDS
    case 2: if (command == 0) {
        digitalWrite(led, HIGH);
      }
      else if (command == 1) {
        digitalWrite(led, LOW);
      }
      else if (command == 2) {
        int led_value = digitalRead(led);
        char char_led_value[] = {led_value};
        node.sendFrame(char_led_value, sizeof(char_led_value), 2);
      }
      break;
    // LIGHT_SENSOR_COMMANDS
    case 3: if (command == 2) {
        readAndSendLightValue();
      } break;
    // BUZZER_COMMANDS
    case 4: if (command == 0) {
        triggerBuzzer();
      } break;
  }
}

// funzione per blink del led di segnalazione
void blinkLed() {
  digitalWrite(led, HIGH);
  delay(100);
  digitalWrite(led, LOW);
  delay(100);
  digitalWrite(led, HIGH);
  delay(100);
  digitalWrite(led, LOW);
  delay(100);
  digitalWrite(led, HIGH);
  delay(100);
  digitalWrite(led, LOW);
}

// funzione accensione buzzer
void triggerBuzzer() {
  tone(buzzer, 1000, 1000);
}

void readAndSendLightValue() {
  // read light value
  int light_value = analogRead(lightSensor);
  char char_light_value[] = {light_value};
  //             data , dataLength , port
  node.sendFrame(char_light_value, sizeof(char_light_value), 3);
}

// inizializzazione pinout
void pinoutInit() {
  // utilizzo pin 6 come output led
  pinMode(led, OUTPUT);
  digitalWrite(led, LOW);
  // utilizzo pin 2 come input sensore di luminosità
  pinMode(lightSensor, INPUT);
  // utilizzo pin 5 come output buzzer
  pinMode(buzzer, OUTPUT);
}

