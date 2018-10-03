using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LargestNElements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            var result = nums.OrderByDescending(x => x).Take(n).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
