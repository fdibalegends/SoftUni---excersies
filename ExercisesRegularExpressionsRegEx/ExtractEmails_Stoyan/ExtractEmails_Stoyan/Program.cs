﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(tewxt);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
