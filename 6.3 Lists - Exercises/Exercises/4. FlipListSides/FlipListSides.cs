using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>(nums.Count);

            for (int i = 1; i < nums.Count - 1; i++)
            {
                result.Add(nums[nums.Count - i - 1]);
            }
            result.Insert(0, nums[0]);

            result.Insert(result.Count, nums[nums.Count - 1]);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
