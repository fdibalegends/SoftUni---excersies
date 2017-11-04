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
            /*dynamic -> its eveerything, it doesnt list all the methods*/
            var student = new {Name = "Joro", Age = 25, ID = 123, Days = int.Parse(Console.ReadLine()) };
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Days);

            DateTime date = new DateTime(2016, 5, 3);
            Console.WriteLine(date.Kind);

            webClient weClient = new webClient(); //namespace-ove
            Random rnd = new Random();
            Console.WriteLine("Random number: " + rnd.Next(1, 100));
        }
    }
}
