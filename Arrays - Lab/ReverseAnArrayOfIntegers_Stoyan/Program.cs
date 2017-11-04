using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfIntegers_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int k = arr.Length-1; k >= 0; k--)
            {
                Console.Write(arr[k] + " ");
            }
            Console.WriteLine();
        }
    }
}
