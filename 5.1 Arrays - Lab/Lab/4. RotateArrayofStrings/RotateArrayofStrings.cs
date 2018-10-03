using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.RotateArrayofStrings
{
    class RotateArrayofStrings
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();

           var last = words
                .Skip(words.Length - 1)
                .ToArray();

            var first = words
                .Take(words.Length - 1)
                .ToArray();

            var result = last
                .Concat(first)
                .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
