using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers_Stoyan
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            double fuelExpences = 0;
            double cargoIncome = 0;
            double cashTechnichal = 0;
            double cashTheoretical = 0;
            double cashPractical = 0;
            for (int i = 1; i <= n; i++)
            {
                int distance = int.Parse(Console.ReadLine());
                double cargo = double.Parse(Console.ReadLine());
                string team = Console.ReadLine();
                

                if (team == "Technical")
                {
                    fuelExpences = 0.7 * (distance * 1600) * 2.5;
                    cargoIncome = 1.5 * (cargo * 1000);
                    double cashTechnichalNew = cargoIncome - fuelExpences;
                    cashTechnichal += cashTechnichalNew; 
                }
                else if (team == "Theoretical")
                {
                    fuelExpences = 0.7 * (distance * 1600) * 2.5;
                    cargoIncome = 1.5 * (cargo * 1000);
                    double cashTheoreticalNew = cargoIncome - fuelExpences;
                    cashTheoretical += cashTheoreticalNew;
                }
                else if (team == "Practical")
                {
                    fuelExpences = 0.7 * (distance * 1600) * 2.5;
                    cargoIncome = 1.5 * (cargo * 1000);
                    double cashPracticalNew = cargoIncome - fuelExpences;
                    cashPractical += cashPracticalNew;
                }
            }
            if (cashPractical > cashTechnichal && cashPractical > cashTheoretical)
            {
                Console.WriteLine($"The Practical Trainers win with ${cashPractical:F3}.");
            }
            else if (cashTechnichal > cashPractical && cashTechnichal> cashTheoretical)
            {
                Console.WriteLine($"The Technical Trainers win with ${cashTechnichal:F3}.");
            }
            else if (cashTheoretical > cashPractical && cashTheoretical > cashTechnichal)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${cashTheoretical:F3}.");
            }
        }
    }
}
