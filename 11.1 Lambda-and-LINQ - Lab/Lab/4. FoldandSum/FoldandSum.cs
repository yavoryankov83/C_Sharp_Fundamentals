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
            var result = new List<int>();

            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var k = nums.Length / 4;

            var firstRowPart = nums
                .Take(k)
                .Reverse()
                .ToArray();

            var secondRowPart = nums
                .Reverse()
                .Take(k)
                .ToArray();

            var firstRow = firstRowPart
                .Concat(secondRowPart)
                .ToArray();

            var secondRow = nums.Skip(k)
                .Take(2 * k)
                .ToArray();

            for (int i = 0; i < firstRow.Length; i++)
            {
                var current = firstRow[i] + secondRow[i];

                result.Add(current);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
