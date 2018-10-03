using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var pattern = @"\b(0x)?[0-9A-F]+\b";

            var numbers = Console.ReadLine();

            var regex = new Regex(pattern);

            var maches = regex.Matches(numbers);

            foreach (Match phone in maches)
            {
                result.Add(phone.Value);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
