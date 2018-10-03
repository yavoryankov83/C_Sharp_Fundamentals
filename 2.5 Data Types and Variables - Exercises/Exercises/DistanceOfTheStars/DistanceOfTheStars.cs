using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOfTheStars
{
    class DistanceOfTheStars
    {
        static void Main(string[] args)
        {
            var earthToStar = 4.22;
            var milkyWay = 26000;
            var milkyWayDiameter = 100000;
            var distanceFromEarth = 46500000000;
            var lightYear = 9450000000000;

            var result1 = earthToStar * lightYear;
            var result2 = milkyWay * lightYear;
            var result3 = milkyWayDiameter * lightYear;
            decimal result4 = (decimal)distanceFromEarth * (decimal)lightYear;

            Console.WriteLine(result1.ToString("e2"));
            Console.WriteLine(result2.ToString("e2"));
            Console.WriteLine(result3.ToString("e2"));
            Console.WriteLine(result4.ToString("e2"));
        }
    }
}
