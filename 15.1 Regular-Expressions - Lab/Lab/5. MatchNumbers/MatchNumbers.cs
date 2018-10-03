using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            Regex regex = new Regex(pattern);

            var input = Console.ReadLine();

            var mached = regex.Matches(input);

            foreach (Match num in mached)
            {
                Console.Write($"{num.Value} ");
            }
            Console.WriteLine();
        }
    }
}
