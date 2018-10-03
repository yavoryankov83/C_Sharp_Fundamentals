using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequence
{
    class IncreasingSequence
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    if (i == nums.Length - 1)
                    {
                        Console.WriteLine("Yes");
                    }
                }
                else
                {
                    Console.WriteLine("No");
                    break;
                }
            }
        }
    }
}
