using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSums_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int lastNumbers = int.Parse(Console.ReadLine());
            long[] arr = new long[num];
            arr[0] = 1;
            

            for (int i = 1; i < num; i++)
            {
                int start = Math.Max(0, i-lastNumbers);
                long sum = 0;
                for (int k = start; k < i; k++)
                {
                    sum = sum + arr[k];
                }
                arr[i] = sum;
            }
            Console.WriteLine(string.Join(" ", arr));
        }   
    }
}
