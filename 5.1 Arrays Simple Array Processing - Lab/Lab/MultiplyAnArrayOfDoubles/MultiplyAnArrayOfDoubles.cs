using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyAnArrayOfDoubles
{
    class MultiplyAnArrayOfDoubles
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var multiplier = double.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= multiplier;
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
