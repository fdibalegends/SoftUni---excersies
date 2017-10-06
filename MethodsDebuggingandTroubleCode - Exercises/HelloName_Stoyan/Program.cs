using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName_Stoyan
{
    class Program
    {
        static string Greeting(string name)
        {
            name = "Hello, " + name + "!";
            return name;
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string greetingName = Greeting(name);
            Console.WriteLine(greetingName);
        }
    }
}
