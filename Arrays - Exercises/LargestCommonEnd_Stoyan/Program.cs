using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = new string[] { };
            string[] words2 = new string[] { };

           words1 =  Console.ReadLine().Split(' ').ToArray();
           words2 = Console.ReadLine().Split(' ').ToArray();

            var length = Math.Min(words1.Length, words1.Length);

            int index = 0;
            int index2 = 0;

            for (int i = 0;i<length ; i++)
            {
                if (words1[i] == words2[i])
                {
                    index++;
                }
                else
                {
                    break;
                }
                
            }
            for (int k = 0; k < length; k++)
                {
                    if (words1[words1.Length - 1 - k] == words2[words2.Length - 1 - k])
                    {
                        index2++;
                    }
                    else
                    {
                        break;
                    }
                }
            if (index > index2)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine(index2);
            }
        }
    }
}
