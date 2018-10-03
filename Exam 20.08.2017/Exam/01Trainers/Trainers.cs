using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01Trainers
{
    class Trainers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var technical = 0.0;
            var theoretical = 0.0;
            var practical = 0.0;
            var team = "";

            for (int i = 0; i < n; i++)
            {
                var distanceInMiles = long.Parse(Console.ReadLine());
                var cargoInTons = double.Parse(Console.ReadLine());
                var teamName = Console.ReadLine();

                long distanceInMeters = distanceInMiles * 1600;
                double cargoInKolos = cargoInTons * 1000;

                double currentParticipantEarnedMoney = (cargoInKolos * 1.5) - (0.7 * distanceInMeters * 2.5);

                if (teamName == "Technical")
                {
                    technical += currentParticipantEarnedMoney;
                }
                else if (teamName == "Theoretical")
                {
                    theoretical += currentParticipantEarnedMoney;
                }
                else
                {
                    practical += currentParticipantEarnedMoney;
                }
            }

            var max = Math.Max(technical, Math.Max(theoretical, practical));

            if (max == technical)
            {
                team = "Technical";
            }
            else if (max == theoretical)
            {
                team = "Theoretical";
            }
            else
            {
                team = "Practical";
            }
            Console.WriteLine($"The {team} Trainers win with ${max:F3}.");
        }
    }
}
