using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNElements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var n = int.Parse(Console.ReadLine());

            var result = new List<int>();

            nums.Sort();
            nums.Reverse();

            for (int i = 0; i < n; i++)
            {
                result.Add(nums[i]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
