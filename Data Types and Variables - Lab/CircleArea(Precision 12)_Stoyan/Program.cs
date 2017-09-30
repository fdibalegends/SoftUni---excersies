using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea_Precision_12__Stoyan
{
    class Program
    {
        static void Main(string[] args)  
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            //area = Math.Round(area, 12);
            //Console.WriteLine(area);
            Console.WriteLine("{0:F12}", area);
        }
    }
}
