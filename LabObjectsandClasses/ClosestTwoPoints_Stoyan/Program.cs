using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints_Stoyan
{
    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static double CalcDistance(Point a, Point b)
        {
            int deltaX = a.X - b.X;
            int deltaY = a.Y - b.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)

                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2]};
                    }
                }
            return closestTwoPoints;
        }


            static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }


        static void PrintDistance(Point[] points)
        {
            double distance = CalcDistance(points[0], points[1]);
            Console.WriteLine("{0:f3}", distance);
        }


        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoints();
            }
            return points;
        }

        static void Main()
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);
            PrintDistance(closestPoints);
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }  
    }
}
