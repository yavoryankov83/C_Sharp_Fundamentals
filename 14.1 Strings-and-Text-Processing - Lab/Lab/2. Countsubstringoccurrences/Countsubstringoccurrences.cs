using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Countsubstringoccurrences
{
    class Countsubstringoccurrences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var searched = Console.ReadLine().ToLower();

            var occurances = 0;

            var index = input.IndexOf(searched);

            while (index != -1)
            {
                occurances++;
                index = input.IndexOf(searched, index + 1);
            }
            Console.WriteLine(occurances);
        }
    }
}
