using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSequence
{
    class EqualSequence
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                var first = nums[0];

                if (nums[i] == first)
                {
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
