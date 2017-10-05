using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare_Stoyan
{
    class Program
    {
        static void repeatingStr(int number)
        {
            Console.WriteLine(new string('-', number * 2));
        }

        static void MiddleMethod(int number)
        {
            Console.Write("-");
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
            
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            repeatingStr(num);
            for (int i = 0; i < num-2; i++)
            {
                MiddleMethod(num);
            }
            repeatingStr(num);
        }
    }
}
