using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers_Stoyan
{
    class Program
    {
        static void Fib(int n)
        {
            int num1 = 1;
            int num2 = 1;
            int sumFib = 1;
            for (int i = 0; i <= n-2; i++)
            {
                if (n < 2)
                {
                   
                    break;
                }
                else
                {
                    sumFib = num1 + num2;
                    num1 = num2;
                    num2 = sumFib;
                }
            }
            Console.WriteLine(sumFib);

        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Fib(num);
        }
    }
}
