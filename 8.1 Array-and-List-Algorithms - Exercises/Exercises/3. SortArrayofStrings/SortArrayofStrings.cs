using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SortArrayofStrings
{
    class SortArrayofStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            input.Sort();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
