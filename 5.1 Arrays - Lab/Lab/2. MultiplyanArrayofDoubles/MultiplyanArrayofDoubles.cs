using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MultiplyanArrayofDoubles
{
    class MultiplyanArrayofDoubles
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var multiplier = double.Parse(Console.ReadLine());

            nums = nums
                .Select(n => n * multiplier)
                .ToArray();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
