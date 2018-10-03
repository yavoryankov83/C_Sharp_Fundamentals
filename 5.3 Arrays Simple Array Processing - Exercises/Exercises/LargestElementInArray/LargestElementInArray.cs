using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElementInArray
{
    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var nums = new int[n];
            var max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
