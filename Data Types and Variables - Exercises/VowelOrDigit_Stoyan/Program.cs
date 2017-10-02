using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            int probe = (int)input;

            if (probe == 97 || probe == 101 || probe == 105 || probe == 111 || probe == 117 || probe == 121)
            {
                Console.WriteLine("vowel");
            }
            else if (probe >= 48 && probe <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
