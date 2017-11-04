using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                   int sum = array[i] + array[k];
                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[i]} + {array[k]} == {sum}");
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
