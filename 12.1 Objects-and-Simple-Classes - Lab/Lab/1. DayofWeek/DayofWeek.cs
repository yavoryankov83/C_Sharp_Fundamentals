using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DayofWeek
{
    class DayofWeek
    {
        static void Main(string[] args)
        {
            var date = DateTime
                .ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo
                .InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
