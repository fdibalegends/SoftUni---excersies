using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 1; i <= n; i++)
            {
                decimal price = ThePriceForACoffe();
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }

        static decimal ThePriceForACoffe()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

            string strDate = Console.ReadLine();

            DateTime myDate = DateTime.ParseExact(strDate, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            decimal dateCount = DateTime.DaysInMonth(myDate.Year, myDate.Month);

            decimal capsuls = decimal.Parse(Console.ReadLine());

            decimal price = (dateCount * capsuls)*pricePerCapsule;

            return price;
        }
    }
}
