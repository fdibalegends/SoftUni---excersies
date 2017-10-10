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
            int index = int.Parse(Console.ReadLine());

            int[] collection = new int[index];

            for (int i = 0; i < collection.Length; i++)
            {
                collection[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < collection.Length; k++)
            {
                Console.Write(collection[index-1] + " ");
                index--;
            }
        }
    }
}
