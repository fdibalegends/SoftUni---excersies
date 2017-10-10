using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3] ;
            numbers[0] = 33;
            string[] str = new string[] {"Pesho", "Moni" };
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[1] == 0);

            int n = int.Parse(Console.ReadLine());

            int[] collection = new int[n];
            for (int i = 0; i < collection.Length; i++)
            {
                collection[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(collection[2]);
        }
    }
}
