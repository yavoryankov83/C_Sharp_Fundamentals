using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInPlace
{
    class ReverseArrayInPlace
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count / 2; i++)
            {
                var temp = nums[i];
                nums[i] = nums[nums.Count - 1 - i];
                nums[nums.Count - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
