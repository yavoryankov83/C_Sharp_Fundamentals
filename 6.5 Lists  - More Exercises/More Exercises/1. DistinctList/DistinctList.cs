using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DistinctList
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = nums
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
