using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object sum = hello + " " + world;
            string allWord = (string)sum;
            Console.WriteLine(allWord);
        }
    }
}
