using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TravelingatLightSpeed
{
    class TravelingatLightSpeed
    {
        static void Main(string[] args)
        {
            var lightYearInKilometers = 9450000000000M;
            var speedOfLightInKilometersPerSecond = 300000M;

            var lightYears = decimal.Parse(Console.ReadLine());

            var lightYear = (lightYearInKilometers / speedOfLightInKilometersPerSecond) * lightYears;

            var weeks = lightYear / 60 / 60 / 24 / 7;
            var days = lightYear / 60 / 60 / 24 % 7;
            var hours = lightYear / 60 / 60 % 24;
            var minutes = lightYear / 60 % 60;
            var seconds = lightYear % 60;

            Console.WriteLine("{0} weeks", Math.Floor(weeks));
            Console.WriteLine("{0} days", Math.Floor(days));
            Console.WriteLine("{0} hours", Math.Floor(hours));
            Console.WriteLine("{0} minutes", Math.Floor(minutes));
            Console.WriteLine("{0} seconds", Math.Floor(seconds));
        }
    }
}
