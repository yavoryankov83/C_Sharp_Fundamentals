using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CountofCapitalLettersinArray
{
    class CountofCapitalLettersinArray
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();

            var count = words.Where(w => w.Length == 1)
                .Count();

            Console.WriteLine(count);
        }
    }
}
