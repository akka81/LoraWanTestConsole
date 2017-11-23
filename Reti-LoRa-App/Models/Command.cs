using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reti_LoRa_App.Models
{
    class Command
    {
        // device port
        public const Int16 LED = 2;
        public const Int16 TRESHOLD_VALUE = 3;
        public const Int16 LIGHT_SENSOR = 4;
        public const Int16 BUZZER = 1;

        // function
        public const int TURN_ON_LED = 1;
        public const int TURN_OFF_LED = 2;
        public const int BLINK_LED = 0;
        public const int READ_LIGHT_SENSOR = 0;
        public const int TRIGGER_BUZZER = 0;
    }
}
