using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeCheckerRefactor_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 2; i<= input; i++)
            {
                bool isItTrue = true;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        isItTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isItTrue}");
            }
        }
    }
}
