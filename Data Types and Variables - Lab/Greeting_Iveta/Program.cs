using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());

            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");

        }
    }
}
