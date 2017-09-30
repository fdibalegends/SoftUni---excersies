using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int courses = int.Parse(Console.ReadLine());

            int a = people / courses;//17/3 = 5  17%3 = 2
            int b = people % courses;
            if (b > 0)
            {
                Console.WriteLine(a + 1);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
