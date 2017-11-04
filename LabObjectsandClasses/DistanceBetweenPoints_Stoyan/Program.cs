using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints_Stoyan
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {

        static double CalcDistanse(Point a, Point b)
        {
            int deltaX = a.X - b.X;
            int deltaY = a.Y - b.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static void Main(string[] args)
        {
           
            string[] p1Values = Console.ReadLine().Split(' ');
            Point p1 = new Point();
            p1.X = int.Parse(p1Values[0]);
            p1.Y = int.Parse(p1Values[1]);

           
            string[] p2Values = Console.ReadLine().Split(' ');
            Point p2 = new Point();
            p2.X = int.Parse(p2Values[0]);
            p2.Y = int.Parse(p2Values[1]);

            double distance = CalcDistanse(p1, p2);
            Console.WriteLine("{0:f3}", distance);
        }
    }
}
