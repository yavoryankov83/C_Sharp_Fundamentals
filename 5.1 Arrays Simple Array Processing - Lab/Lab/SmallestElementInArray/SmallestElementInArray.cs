using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var min = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
