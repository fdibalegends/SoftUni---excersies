using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            long numPic = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filteredPics = (long)Math.Ceiling(numPic - (numPic - (numPic * (filterFactor * 0.01))));

            long seconds1 = numPic * filterTime;
            long seconds2 = filteredPics * uploadTime;
            long totalsec = seconds1 + seconds2;

            TimeSpan result = TimeSpan.FromSeconds(totalsec);
            string format = result.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(format);


        }
    }
}
