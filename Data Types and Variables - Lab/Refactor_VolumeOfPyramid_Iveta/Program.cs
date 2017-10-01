using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Refactor_VolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volumePyramid = (length * width * height) / 3; 
            Console.WriteLine("Pyramid Volume: {0:F2}", volumePyramid);

            //имената бяха неправилни, формулата, ненужно инициализиране на променливи в началото
        }
    }
}
