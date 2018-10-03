using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var daysCount = int.Parse(Console.ReadLine());
            var runnersCount = long.Parse(Console.ReadLine());
            var averageLpsCount = int.Parse(Console.ReadLine());
            var trackLeght = long.Parse(Console.ReadLine());
            var trackCapasity = int.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            var allRunners = trackCapasity * daysCount;

            if (runnersCount > allRunners)
            {
                runnersCount = allRunners;
            }

            var distance = (runnersCount * averageLpsCount * trackLeght) / 1000.0;

            var money = distance * moneyPerKilometer;

            Console.WriteLine($"Money raised: {money:F2}");
        }
    }
}
