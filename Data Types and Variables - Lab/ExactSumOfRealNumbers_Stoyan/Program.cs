using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNumbers_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < num; i++)
            {
                decimal realNumber = decimal.Parse(Console.ReadLine());

                sum += realNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
