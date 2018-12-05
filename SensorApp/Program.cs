using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace SensorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Sensor sensor = new Sensor("Temperature");
            
            //sensor.NewValue += new Sensor.NewValueHandler(OnNewValue);
            sensor.NewValue += OnNewValue;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                sensor.AddValue(random.NextDouble() * 46);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Finished!");
        }

        static void OnNewValue(object sender, double value)
        {
            Console.WriteLine($"Sender='{sender.GetType()}' Value='{value}'");
        }
    }
}
