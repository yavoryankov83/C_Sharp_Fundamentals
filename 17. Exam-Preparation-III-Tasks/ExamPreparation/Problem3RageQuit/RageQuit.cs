using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem3RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var counts = new HashSet<char>();
            StringBuilder builder = new StringBuilder();
            var pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);
            var mached = regex.Matches(input);

            foreach (Match pair in mached)
            {
                var text = pair.Groups[1].Value;
                var count1 = int.Parse(pair.Groups[2].Value);

                for (int i = 0; i < count1; i++)
                {
                    builder.Append(text.ToUpper());
                }
            }

            var count = builder.ToString().ToCharArray().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(builder.ToString());
        }
    }
}
