using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower_Stoyan
{
    class Program
    {
        static double PowerNumber(double num, double pow)
        {
            num = Math.Pow(num, pow);
            return num;
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            double power = PowerNumber(num, pow);
            Console.WriteLine(power);
        }
    }
}
