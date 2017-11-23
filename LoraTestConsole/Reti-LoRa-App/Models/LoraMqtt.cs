using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Reti_LoRa_App.Models
{
    class LoraMqtt
    {
        private const string appid = LoRaNetworkApplication.appid;
        private const string deveui = LoRaNetworkApplication.deveui;
        private const int lightPort = Command.LED;
        private const string user = LoRaNetworkApplication.username;

        public void ReadLigthSensor()
        {

            //MQTTClient mQTTClient = new MQTTClient("ptnetsuite.a2asmartcity.io",8883);
            //mQTTClient.Connect("reti::1");
            //mQTTClient.Subscriptions.Add(new Subscription($"/sub/v1/users/{user}/apps/{appid}/devices/{deveui}/uplink/{lightPort}"));
            //mQTTClient.Connected += MQTTClient_Connected;
            //mQTTClient.MessageReceived += MQTTClient_MessageReceived;

            //secure connection
            MqttClient mqttClient = new MqttClient("ptnetsuite.a2asmartcity.io", 8883, true, new System.Security.Cryptography.X509Certificates.X509Certificate("./loranetsuite.crt"), null, MqttSslProtocols.TLSv1_2);


            mqttClient.Connect("reti::1", LoRaNetworkApplication.username, LoRaNetworkApplication.password);

            mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;

            mqttClient.Subscribe(new string[] { $"/sub/v1/users/{user}/apps/{appid}/devices/{deveui}/uplink/{lightPort}" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

        }

        //private void MQTTClient_Connected(object sender, EventArgs e)
        //{
        //    Console.WriteLine("connected!");
        //}

        //private void MQTTClient_MessageReceived(string topic, QoS qos, byte[] payload)
        //{
        //    Console.WriteLine(topic);
        //    Console.WriteLine(payload.ToString());
        //}

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string message = System.Text.Encoding.Default.GetString(e.Message);
            Console.WriteLine($"mex received: {message} - topic: {e.Topic}");

        }
    }
}
