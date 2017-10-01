using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number++)
            {
                int sumOfDigits = 0;
                int digit = number; //цифрата е числото за текущия оборот

                while (digit > 0)
                {
                    sumOfDigits = sumOfDigits + digit % 10;
                    digit = digit / 10;
                }

                if ((sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11))
                {
                    Console.WriteLine("{0} -> True", number);
                }
                else
                {
                    Console.WriteLine("{0} -> False", number);
                }
                //bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                //Console.WriteLine("{0} -> {1}", number, special);
            }
        }
    }
}
