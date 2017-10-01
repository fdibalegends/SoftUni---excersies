using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexFormat_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            Console.WriteLine(Convert.ToInt16(value, 16));
        }
    }
}
