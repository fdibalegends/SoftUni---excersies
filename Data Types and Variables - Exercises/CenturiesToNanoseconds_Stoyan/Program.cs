using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            long horus = days * 24;
            long minutes = horus * 60;
            long seconds = minutes * 60;
            long miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000M;
            decimal nanoseconds = microseconds * 1000M;

                Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {horus} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
                 
        }
    }
}
