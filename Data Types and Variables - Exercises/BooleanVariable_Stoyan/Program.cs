using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            string tellTheTruth = Console.ReadLine();
           bool yesOrNo = Convert.ToBoolean(tellTheTruth);
            
            if (yesOrNo)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
