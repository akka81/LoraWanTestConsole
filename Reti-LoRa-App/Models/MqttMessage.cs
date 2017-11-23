using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reti_LoRa_App.Models
{
    public class MqttMessage
    {
        public int port { get; set; }                       /* Port where the message should be sent. Range [1-255] */
        public Int16 payload { get; set; }                /* Message payload (lowercase hexadecimal string) */
        public bool confirmed { get; set; }              /* (Optional) Tells whether a confirmed downlink is requested. Default: false */
        public string window { get; set; }             //"BOTH",                 /* (Optional) Specifies which rx window should be used: RX1, RX2 or any(BOTH). Default: BOTH */
        public int priority { get; set; }              /* (Optional) Message priority, used to sort messages in the queue. Default: 0*/

        public MqttMessage(int port, Int16 payload)
        {
            this.port = port;
            this.payload = payload;
            confirmed = false;
            window = "BOTH";
            priority = 1;
        }

    }
}
