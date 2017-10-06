using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder_Stoyan
{
    class Program
    {
        static decimal ReverseNumber(decimal num)
        {
           
            decimal result = 0;
            int count = 0;
            
            while ((int)num != 0)
            {
                count++;
                num = num / 10;
            }
            while (num != ((int)num))
            {
                
                num = num * 10;
            }
            while (num > 0)
                {
                    result = result * 10 + num % 10;
                    num = num/ 10;
                    num = (int)num; 
                }
            for (int i = 1; i <= count; i++)
            {
                result = result / 10;
            }
           
            return result;

            
        }
        static int ReverseNumberInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int num;
            decimal num1;

            if (int.TryParse(input, out num))
            {
                int printing = ReverseNumberInt(num);
                Console.WriteLine(printing);
            }
            else if(decimal.TryParse(input, out num1))
            {
                decimal printing = ReverseNumber(num1);
                string proba = printing.ToString("#.######################");
                Console.WriteLine(proba);

            }
            
         
            
        }
    }
}
