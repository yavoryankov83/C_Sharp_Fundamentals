using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var input = Console.ReadLine();

            var regex = new Regex(pattern);

            var mached = regex.Matches(input);

            foreach (Match item in mached)
            {
                Console.Write(item + " ");
            }
        }
    }
}
