using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Reti_LoRa_App.Models
{

    public class LoraRest
    {
        //variable
        private string username;
        private string password;
        private AccessToken authToken;
        private string appid = LoRaNetworkApplication.appid;
        private string deveui = LoRaNetworkApplication.deveui;

        public LoraRest()
        {
            username = LoRaNetworkApplication.username;
            password = LoRaNetworkApplication.password;
        }


        public async Task<bool> Login()
        {
            HttpClient httpClient = new HttpClient();
            Newtonsoft.Json.JsonSerializer jser = new Newtonsoft.Json.JsonSerializer();

            httpClient.BaseAddress = new Uri("https://ptnetsuite.a2asmartcity.io/");

            //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Credentials credentials = new Credentials();
            credentials.username = username;
            credentials.password = password;

            StringWriter stringWriter = new System.IO.StringWriter();

            jser.Serialize(stringWriter, credentials);



            StringContent authContent = new StringContent(stringWriter.ToString(), Encoding.UTF8, "application/json");


            // StringContent authContent = new StringContent($"{{ \"username\":\"{username}\",\"password\":\"{password}\"}}",Encoding.UTF8,"application/json");


            HttpResponseMessage resp = await httpClient.PostAsync("api/auth/login", authContent);

            string respBody = await resp.Content.ReadAsStringAsync();


            StringReader reader = new StringReader(respBody);

            authToken = (AccessToken)jser.Deserialize(reader, typeof(AccessToken));

            if (resp.IsSuccessStatusCode)
                return true;
            else
                return false;

        }


        public async Task<bool> TriggerBuzzer()
        {
            HttpClient httpClient = new HttpClient();
            Newtonsoft.Json.JsonSerializer jser = new Newtonsoft.Json.JsonSerializer();

            httpClient.BaseAddress = new Uri("https://ptnetsuite.a2asmartcity.io/");

            System.IO.StringWriter stringWriter = new System.IO.StringWriter();

            MqttMessage triggerBuzzerMex = new MqttMessage(1, 0);

            jser.Serialize(stringWriter, triggerBuzzerMex);

            StringContent authContent = new StringContent(stringWriter.ToString(), Encoding.UTF8, "application/json");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken.accessToken);

            HttpResponseMessage resp = await httpClient.PostAsync($"/api/mqtt/v1/users/{username}/apps/{appid}/devices/{deveui}/downlink", authContent);

            string respBody = await resp.Content.ReadAsStringAsync();


            if (resp.IsSuccessStatusCode)
                return true;
            else
                return false;

        }

        public async Task<bool> DoCommand(int devicePort, Int16 function)
        {
            HttpClient httpClient = new HttpClient();
            Newtonsoft.Json.JsonSerializer jser = new Newtonsoft.Json.JsonSerializer();

            httpClient.BaseAddress = new Uri("https://ptnetsuite.a2asmartcity.io/");

            System.IO.StringWriter stringWriter = new System.IO.StringWriter();

            MqttMessage commandMessage = new MqttMessage(devicePort, function);

            jser.Serialize(stringWriter, commandMessage);

            StringContent authContent = new StringContent(stringWriter.ToString(), Encoding.UTF8, "application/json");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken.accessToken);

            HttpResponseMessage resp = await httpClient.PostAsync($"/api/mqtt/v1/users/{username}/apps/{appid}/devices/{deveui}/downlink", authContent);

            string respBody = await resp.Content.ReadAsStringAsync();


            if (resp.IsSuccessStatusCode)
                return true;
            else
                return false;
        }

        
    }
}
