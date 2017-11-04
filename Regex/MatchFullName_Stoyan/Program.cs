using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (Match match in matchedNames)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
