using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod_Stoyan
{
    class Program
    {
        static int GetMax(int num1, int num2)
        {
            int minim = 0;
            if (num1 >= num2)
            {
                minim = num1;
            }
            else
            {
                minim = num2;
            }
            return minim;
           
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int temp = GetMax(num1, num2);
            int perm = GetMax(temp, num3);
            Console.WriteLine(perm);
        }
    }
}
