using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var studioPrice = 0d;
            var doublePrice = 0d;
            var suitePrice = 0d;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;

                if (nightsCount > 7)
                {
                    studioPrice = studioPrice - (studioPrice * 0.05);
                }

                doublePrice = 65;
                suitePrice = 75;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;

                doublePrice = 72;

                if (nightsCount > 14)
                {
                    doublePrice = doublePrice - (doublePrice * 0.1);
                }

                suitePrice = 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;

                if (nightsCount > 14)
                {
                    suitePrice = suitePrice - (suitePrice* 0.15);
                }
            }

            Console.WriteLine( nightsCount > 7
                && (month == "September" || month == "October")
                ? $"Studio: {(nightsCount - 1) * studioPrice:F2} lv."
                : $"Studio: {nightsCount * studioPrice:F2} lv.");

            Console.WriteLine($"Double: {nightsCount * doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {nightsCount * suitePrice:F2} lv.");
        }
    }
}
