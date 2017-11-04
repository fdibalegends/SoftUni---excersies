using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberName = Console.ReadLine();

            Dictionary<string, List<int>> numbers = new Dictionary<string, List<int>>();

            numbers["one"] = new List<int> {1, -1};
            numbers["zero"] = new List<int> {0};
            numbers["two"] = new List<int> { 2, -2 };
            numbers["three"] = new List<int> { -3, 3 };

            numbers.Remove("zero");

            foreach (KeyValuePair<string, List<int>> item in numbers)
            {
                Console.WriteLine(item.Key + " - " + String.Join(" ", item.Value));
            }
        }
    }
}
