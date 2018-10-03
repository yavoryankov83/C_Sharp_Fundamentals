using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var ordered = nums
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", ordered));
        }
    }
}
