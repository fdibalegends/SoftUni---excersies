using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle_Stoyan
{
    class Program
    {
        static void PrintingTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i<=num;i++)
            {
                PrintingTriangle(1, i);
            }
            for (int m = num-1; m >= 0; m--)
            {
                PrintingTriangle(1, m);
            }
        }
    }
}
