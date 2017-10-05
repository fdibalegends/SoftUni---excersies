using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfIntegerNumber_Stoyan
{
    class Program
    {
        static void whatIsTheNumber(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            whatIsTheNumber(num);
        }
    }
}
