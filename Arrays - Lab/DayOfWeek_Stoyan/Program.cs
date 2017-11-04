using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDay = int.Parse(Console.ReadLine());

            string[] days = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (numDay > 0 && numDay <= 7)
            {
                Console.WriteLine(days[numDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day");
            }
        }
    }
}
