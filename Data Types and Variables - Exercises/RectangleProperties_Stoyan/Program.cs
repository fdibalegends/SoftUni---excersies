﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(2*(width+height));
            Console.WriteLine(width*height);
            Console.WriteLine(Math.Sqrt(width*width+height*height));
        }
    }
}
