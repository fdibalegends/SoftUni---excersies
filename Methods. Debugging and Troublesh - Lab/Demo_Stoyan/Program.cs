using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Stoyan
{
    class Program
    {
        static void PrintSymbols(int x, char symbol)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"{symbol}");
            }
        }
        static void Main(string[] args)
        {
            PrintSymbols(3, '#');
            Console.WriteLine("Hello");
            PrintSymbols(2, '@');
        }
    }
}
