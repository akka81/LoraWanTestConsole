using Reti_LoRa_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reti_LoRa_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // make LoraRest object
            LoraRest loraRest = new LoraRest();
            // make ui
            Form1 mainPage = new Form1(loraRest);


            // inital default state
            mainPage.disconnectedDevice();
            // try connection
            mainPage.tryConnectionDevice();
            Console.WriteLine("Try to connect");
            bool result = Task.Run(async () => { return await loraRest.Login(); }).GetAwaiter().GetResult();
            //check result
            if (result)
            {
                mainPage.connectedDevice();
                Console.WriteLine("Connected");
                // run ui
                Application.Run(mainPage);
            }
            else
            {
                mainPage.disconnectedDevice();
                Console.WriteLine("Not Connected");
                // run ui
                Application.Run(mainPage);
            }

        }
    }
}
