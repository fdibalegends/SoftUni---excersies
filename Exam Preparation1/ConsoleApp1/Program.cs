using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            DateTime time = DateTime.ParseExact(str, "HH:mm:ss", CultureInfo.InvariantCulture);
            int steps = int.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());

            int seconds = steps * secondsPerStep;

            time = time.AddSeconds(seconds);

            Console.WriteLine($"Time Arrival: {time.Hour:00}:{time.Minute:00}:{time.Second:00}");
        }
    }
}
