using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDay = int.Parse(Console.ReadLine());

            string[] dayOfWeek = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (numDay <= 7 && numDay > 0)
            {
                Console.WriteLine(dayOfWeek[numDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
