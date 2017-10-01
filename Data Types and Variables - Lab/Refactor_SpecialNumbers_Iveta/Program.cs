using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Refactor_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            for (int number = 1; number <= n; number++)
            {
                int digit = number;  
                int sumOfDigits = 0; 

                while (digit > 0)
                {
                    sumOfDigits += digit % 10; 
                    digit = digit / 10;
                }

                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{number} -> {special}");
            }
        }
    }
}
