using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int temp = b;
            b = a;
            a = temp;

            Console.WriteLine($"Before:");
            Console.WriteLine($"a = 5");
            Console.WriteLine($"b = 10");
            Console.WriteLine($"After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

        }
    }
}
