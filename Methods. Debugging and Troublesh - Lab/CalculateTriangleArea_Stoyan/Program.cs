using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea_Stoyan
{
    class Program
    {
        static double Area(double num1, double num2)
        {
            return (num1 * num2) / 2;
        }
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double last = Area(height, width);
            Console.WriteLine(last);
        }
    }
}
