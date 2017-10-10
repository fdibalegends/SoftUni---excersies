using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds_Stoyan
{
    class Program
    {
        static void MultiplyedOddAndEvenSums(int num)
        {
            num = Math.Abs(num);
            int sumEven = 0;
            int sumOdd = 0;
            while (num>0)
            {
                int smallerNum;
                smallerNum = num % 10;

                if (smallerNum % 2 == 0)
                {
                    sumEven = sumEven + smallerNum;
                }
                else
                {
                    sumOdd = sumOdd + smallerNum;
                }

                num = (int)(num / 10);
            }
            Console.WriteLine(sumEven*sumOdd);
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            MultiplyedOddAndEvenSums(input);
        }
    }
}
