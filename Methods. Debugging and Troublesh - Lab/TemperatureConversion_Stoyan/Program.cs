using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion_Stoyan
{
    class Program
    {
        static double FarenhaidToCelsius(double input)
        {
            input = (input - 32) * 5 / 9;
            return input;
        }
        static void Main(string[] args)
        {
            double farenhaid = double.Parse(Console.ReadLine());
            double celsius = FarenhaidToCelsius(farenhaid);
            Console.WriteLine($"{celsius:F2}");
        }
    }
}
