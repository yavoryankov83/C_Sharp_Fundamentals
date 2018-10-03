using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem1SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            var leavingTime = Console.ReadLine().Split(':');
            var stepsCount = BigInteger.Parse(Console.ReadLine());
            var stepsTime = BigInteger.Parse(Console.ReadLine());

            var allTime = stepsCount * stepsTime;
            var timeHours = int.Parse(leavingTime[0]) * 60 * 60;
            var timeMinutes = int.Parse(leavingTime[1]) * 60;
            BigInteger time = timeHours + timeMinutes + (int.Parse(leavingTime[2]));
            var all = allTime + time;

            var hours = (all / (60 * 60)) % 24;
            var minutes = (all / 60) % 60;
            var seconds = all % 60;

            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}
