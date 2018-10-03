using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingAtLightSpeed
{
    class TravelingAtLightSpeed
    {
        static void Main(string[] args)
        {
            var lightYears = decimal.Parse(Console.ReadLine());
            var killometers = lightYears * 9450000000000;

            var perSeconds = 300000m / killometers;
            var perminutes = 300000m * 60 / killometers;
            var perHours = killometers / (300000m * 60 * 60);
            var perDays = killometers / (300000m * 60 * 60 * 24);
            var perWeeks = killometers / (300000m * 60 * 60 * 24 * 7);

            var days = (killometers % (300000m * 60 * 60 * 24 * 7)) / (300000m * 60 * 60 * 24);
            var hours = ((killometers % (300000m * 60 * 60 * 24 * 7)) % (300000m * 60 * 60 * 24)) / (300000m * 60 * 60);
            var minutes = (((killometers % (300000m * 60 * 60 * 24 * 7)) % (300000m * 60 * 60 * 24)) % (300000m * 60 * 60)) / (300000m * 60);
            var seconds = ((((killometers % (300000m * 60 * 60 * 24 * 7)) % (300000m * 60 * 60 * 24)) % (300000m * 60 * 60)) % (300000m * 60)) / 300000m;

            //Console.WriteLine(perWeeks.ToString("0") + " weeks");
            Console.WriteLine(Math.Floor(perWeeks) + " weeks");

            //Console.WriteLine(days.ToString("0") + " days");
            Console.WriteLine(Math.Floor(days) + " days");

            //Console.WriteLine(hours.ToString("0") + " hours");
            Console.WriteLine(Math.Floor(hours) + " hours");

            //Console.WriteLine(minutes.ToString("0") + " minutes");
            Console.WriteLine(Math.Floor(minutes) + " minutes");

            //Console.WriteLine(seconds.ToString("0") + " seconds");
            Console.WriteLine(Math.Floor(seconds) + " seconds");
        }
    }
}
