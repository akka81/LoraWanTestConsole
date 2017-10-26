using System;
using System.Threading.Tasks;

namespace LoraTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press s for subscribe");
            string c = Console.ReadLine();




            if (c.ToLower() != "s")
            {
                LoraRest loraRest = new LoraRest("reti", "r3t1sp4");

                bool result = Task.Run(async () => { return await loraRest.Login(); }).GetAwaiter().GetResult();

                if (result)
                {
                    Console.WriteLine("Connection to a2a network successfull!");
                    Console.ReadLine();
                    Console.WriteLine("triggering Buzzer");
                    Task.Run(async () => { return await loraRest.TriggerBuzzer(); }).GetAwaiter().GetResult();
                    Console.WriteLine("executed");
                }
                else
                {
                    Console.WriteLine("Connection to a2a network failed!");
                }
            }
            else
            {
                LoraMqtt loraMqtt = new LoraMqtt();
                loraMqtt.ReadLigthSensor();
            }
            Console.ReadLine();
        }
    }
}
