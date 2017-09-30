using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = numberPeople / capacity; //17 / 3 = 5
            int leftPeople = numberPeople % capacity; //17 % 2 = 2
            
            if(leftPeople > 0)
            {
                Console.WriteLine(courses + 1);
            }
            else
            {
                Console.WriteLine(courses);
            }
        }
    }
}
