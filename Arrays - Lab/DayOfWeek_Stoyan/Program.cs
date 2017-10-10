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
            string[] daysOfWeek = new string[7];
            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            int day = int.Parse(Console.ReadLine());

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[day-1]);
            }
        }
    }
}
