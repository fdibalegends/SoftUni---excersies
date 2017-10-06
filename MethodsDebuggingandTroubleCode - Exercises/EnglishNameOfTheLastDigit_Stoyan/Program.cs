using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit_Stoyan
{
    class Program
    {
        static void NameTheLastDigit(long num)
        {
            if (num % 10 == 0)
            {
               Console.WriteLine("zero");
            }
            else if (num%10 == 1 || num % 10 == -1)
            {
                Console.WriteLine("one");
            }
            else if (num % 10 == 2 || num % 10 == -2)
            {
                Console.WriteLine("two");
            }
            else if (num % 10 == 3 || num % 10 == -3)
            {
                Console.WriteLine("three");
            }
            else if (num % 10 == 4 || num % 10 == -4)
            {
                Console.WriteLine("four");
            }
            else if (num % 10 == 5 || num % 10 == -5)
            {
                Console.WriteLine("five");
            }
            else if (num % 10 == 6 || num % 10 == -6)
            {
                Console.WriteLine("six");
            }
            else if (num % 10 == 7 || num % 10 == -7)
            {
                Console.WriteLine("seven");
            }
            else if (num % 10 == 8 || num % 10 == -8)
            {
                Console.WriteLine("eight");
            }
            else if (num % 10 == 9 || num % 10 == -9)
            {
                Console.WriteLine("nine");
            }
            
        }
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            NameTheLastDigit(num);
        }
    }
}
