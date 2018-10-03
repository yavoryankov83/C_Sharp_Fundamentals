using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesReverse
{
    class RemoveNegativesReverse
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] >= 0)
                {
                    result.Add(nums[i]);
                }
            }
            result.Reverse();

            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
