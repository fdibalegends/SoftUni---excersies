using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoRegex_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[\d]";
            string text = @"123456";

            MatchCollection matches = Regex.Matches(text, pattern);

            Regex.Match(text, pattern);

            foreach (Match m in matches)
            {
                Console.WriteLine("'{0}', found at index {1}.",m.Value, m.Index);
            }

        }
    }
}
