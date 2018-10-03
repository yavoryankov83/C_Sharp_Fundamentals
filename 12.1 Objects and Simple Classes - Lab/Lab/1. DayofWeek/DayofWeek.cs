using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.DayofWeek
{
    class DayofWeek
    {
        static void Main(string[] args)
        {
            var dateAsString = Console.ReadLine();

            var date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
