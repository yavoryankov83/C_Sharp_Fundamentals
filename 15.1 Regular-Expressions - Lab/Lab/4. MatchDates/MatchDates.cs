using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4}\b)";

            Regex regex = new Regex(pattern);

            var input = Console.ReadLine();

            var mached = regex.Matches(input);

            foreach (Match data in mached)
            {
                Console.WriteLine($"Day: {data.Groups["day"].Value}, Month: {data.Groups["month"].Value}, Year: {data.Groups["year"].Value}");
            }
        }
    }
}
