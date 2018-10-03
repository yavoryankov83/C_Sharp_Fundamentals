using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FoldandSum
{
    class FoldandSum
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = nums.Length / 4;

            var leftRow = nums
                .Take(k)
                .Reverse()
                .ToArray();

            var rightRow = nums
                .Reverse()
                .Take(k)
                .ToArray();

            var upperRow = leftRow
                .Concat(rightRow)
                .ToArray();

            var lowerRow = nums
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var sum = new int[lowerRow.Length];

            for (int i = 0; i < lowerRow.Length; i++)
            {
                sum[i] = lowerRow[i] + upperRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
