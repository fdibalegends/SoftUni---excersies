using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            //h ttps://regex101.com/r/LlOHWX/1

            string pattern = @"([^0-9]+)(\d+)";
            string input = Console.ReadLine();
            //RegexOptions options = RegexOptions.Multiline;

            StringBuilder result = new StringBuilder();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                var word = m.Groups[1].ToString().ToUpper(); //всичко различно от цифра
                var count = int.Parse(m.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }

            }

            int uniqueChars = result.ToString().Distinct().Count(); //ще върне count 
            Console.WriteLine($"Unique symbols used: {uniqueChars}");
            Console.WriteLine(result.ToString());
        }
    }
}