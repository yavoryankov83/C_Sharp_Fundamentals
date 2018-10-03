using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var pattern = @"(?<power>\d+|[JQKA]+)(?<suit>[SHDC])";

            Regex regex = new Regex(pattern);
            var mached = regex.Matches(Console.ReadLine());

            foreach (Match card in mached)
            {
                var power = card.Groups["power"].Value;
                var suit = card.Groups["suit"].Value;

                int number;
                var parst = int.TryParse(power, out number);

                if (parst == true)
                {
                    if (number >= 2 && number <= 10) result.Add(card.Groups[0].Value);
                }
                else if (power == "J" || power == "Q" || power == "K" || power == "A")
                {
                    result.Add(card.Groups[0].Value);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
