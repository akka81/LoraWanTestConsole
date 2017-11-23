using Reti_LoRa_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reti_LoRa_App
{
    public partial class Form1 : Form
    {
        // variables
        private LoraRest loraRest { get; set; }

        public Form1(LoraRest lora)
        {
            InitializeComponent();
            this.loraRest = lora;
        }

        public void disconnectedDevice()
        {
            this.device_status_label.Text = "Disconnected";
        }
        public void tryConnectionDevice()
        {
            this.device_status_label.Text = "Try connection...";
        }
        public void connectedDevice()
        {
            this.device_status_label.Text = "Connected";
        }

        private void trigger_buzzer_Click(object sender, EventArgs e)
        {
            if (loraRest != null)
            {
                Console.WriteLine("TriggerBuzzer_Command");
                Task.Run(async () => { return await loraRest.DoCommand(Command.BUZZER, Command.TRIGGER_BUZZER); }).GetAwaiter().GetResult();
            }
            else
            {
                Console.WriteLine("TriggerBuzzer: invalid LoraRest object");
            }

        }

        private void turn_on_led_button_Click(object sender, EventArgs e)
        {
            if (loraRest != null)
            {
                Console.WriteLine("TurnOnLed_Command");
                Task.Run(async () => { return await loraRest.DoCommand(Command.LED, Command.TURN_ON_LED); }).GetAwaiter().GetResult();
            }
            else
            {
                Console.WriteLine("TurnOnLed: invalid LoraRest object");
            }
        }

        private void set_delta_button_Click(object sender, EventArgs e)
        {   
            Int16 tresholdValue = Convert.ToInt16(this.light_delta_control.Value);

            if (loraRest != null)
            {
                Console.WriteLine("SetTresholdValue_Command");
                Task.Run(async () => { return await loraRest.DoCommand(Command.TRESHOLD_VALUE, tresholdValue); }).GetAwaiter().GetResult();
            }
            else
            {
                Console.WriteLine("SetTresholdValue_Command: invalid LoraRest object");
            }
        }

        private void turn_off_led_button_Click(object sender, EventArgs e)
        {
            if (loraRest != null)
            {
                Console.WriteLine("TurnOffLed_Command");
                Task.Run(async () => { return await loraRest.DoCommand(Command.LED, Command.TURN_OFF_LED); }).GetAwaiter().GetResult();
            }
            else
            {
                Console.WriteLine("TurnOffLed_Command: invalid LoraRest object");
            }
        }

        private void blick_led_Click(object sender, EventArgs e)
        {
            if (loraRest != null)
            {
                Console.WriteLine("BlinkLed_Command");
                Task.Run(async () => { return await loraRest.DoCommand(Command.LED, Command.BLINK_LED); }).GetAwaiter().GetResult();
            }
            else
            {
                Console.WriteLine("BlinkLed_Command: invalid LoraRest object");
            }
        }
    }
}
