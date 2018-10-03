using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var separators = ".  ,:  ; ( ) [ ] \" \' \\ / ! ? ".ToCharArray();

            var text = Console.ReadLine()
                .ToLower()
                .Split(separators,StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = text
                .Where(t => t.Length < 5)
                .OrderBy(t => t)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
