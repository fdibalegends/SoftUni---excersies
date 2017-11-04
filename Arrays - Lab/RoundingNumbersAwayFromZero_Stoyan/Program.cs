using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbersAwayFromZero_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] >= 0)
                {

                    Console.WriteLine($"{array[i]} >= {Math.Floor(Math.Abs(array[i]) + 0.5)}");
                }
                else
                {
                    Console.WriteLine($"{array[i]} >= -{Math.Floor(Math.Abs(array[i]) + 0.5)}");
                }
            }
        }
    }
}
