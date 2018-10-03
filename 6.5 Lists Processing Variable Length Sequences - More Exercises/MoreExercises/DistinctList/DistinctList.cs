using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        nums.RemoveAt(j);
                        i = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
