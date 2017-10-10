using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange_Stoyan
{
    class Program
    {
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            for (int i = startNum; i <= endNum; i++)
            {
                if (i == 1) return false;
                if (i == 2) return true;
                if (i % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(i));

                for (int k = 3; k <= boundary; k += 2)
                {
                    if (i % k == 0) return false;
                }
            }
        }
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

        }
    }
}
