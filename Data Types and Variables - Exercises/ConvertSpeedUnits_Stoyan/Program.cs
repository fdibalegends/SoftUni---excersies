using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float sumSec = (hours * 3600) + (minutes * 60) + seconds;
            float sumHours = sumSec / 3600;
            float ms = distance / sumSec;
            float kh = (distance / 1000) / sumHours;
            float mh = (distance / 1609) / sumHours;
            Console.WriteLine($"{ms.ToString():F6}");
            Console.WriteLine($"{kh.ToString():F6}");
            Console.WriteLine($"{mh.ToString():F6}");

        }
    }
}
