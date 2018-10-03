using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.InsertionSortUsingList
{
    class InsertionSortUsingList
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                var after = i + 1;

                while (after > 0)
                {
                    if (nums[after] < nums[after - 1])
                    {
                        var temp = nums[after];
                        nums[after] = nums[after - 1];
                        nums[after - 1] = temp;
                    }

                    after--;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
