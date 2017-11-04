using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", provider: CultureInfo.InvariantCulture);
            Console.WriteLine(a.DayOfWeek);
        }
    }
}
