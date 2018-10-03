using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem1HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            var wingFlaps = BigInteger.Parse(Console.ReadLine());
            var distance = decimal.Parse(Console.ReadLine());
            var endurance = BigInteger.Parse(Console.ReadLine());

            var totalDistance = CalcDistance(wingFlaps, distance);
            var totalTime = CalcTime(wingFlaps, endurance);

            Console.WriteLine($"{totalDistance:F2} m.");
            Console.WriteLine($"{totalTime} s.");

        }
        static decimal CalcDistance(BigInteger wingFlaps, decimal distance)
        {
            var meters = wingFlaps / 1000;
            var totalDistance = (decimal)meters * distance;

            return totalDistance;
        }
        static BigInteger CalcTime(BigInteger wingFlaps, BigInteger endurance)
        {
            var travelSeconds = wingFlaps / 100;
            var restSeconds = wingFlaps / endurance * 5;
            var totalTime = travelSeconds + restSeconds;

            return totalTime;
        }
    }
}
