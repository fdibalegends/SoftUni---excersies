using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues_Stoyan
{
    class Program
    {
        static int GreaterInt(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static char GreaterChar(char num1, char num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static string GreaterString(string num1, string num2)
        {
            if (num1.CompareTo( num2)>=0)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int output = GreaterInt(num1, num2);
                Console.WriteLine(output);

            }
            else if (input == "char")
            {
                char input1 = char.Parse(Console.ReadLine());
                char input2 = char.Parse(Console.ReadLine());
                char output = GreaterChar(input1, input2);
                Console.WriteLine(output);
            }
            else if (input == "string")
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                string output = GreaterString(input1, input2);
                Console.WriteLine(output);
            }
        }
    }
}
