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
            var separators = ". , : ; ( )[ ] \" ' \\ / ! ?".ToCharArray();
            var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            words = words
                .Where(w => w.Length < 5)
                .Select(w => w.ToLower())
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
