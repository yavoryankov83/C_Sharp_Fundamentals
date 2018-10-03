using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.IncreasingSequenceofElements
{
    class IncreasingSequenceofElements
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count - 1; i++)
            {
                var current = nums[i];
                var next = nums[i + 1];

                if (next < current)
                {
                    Console.WriteLine("No");
                    return;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
