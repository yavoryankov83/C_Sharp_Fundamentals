using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            nums = nums
                .Where(n => Math.Sqrt(n) == (int)Math.Sqrt(n))
                .OrderByDescending(n => n)
                .ToList();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
