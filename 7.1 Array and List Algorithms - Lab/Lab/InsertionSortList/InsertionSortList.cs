using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortList
{
    class InsertionSortList
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count - 1; i++)
            {
                var after = i + 1;

                while (after > 0)
                {
                    if (nums[after] < nums[after - 1])
                    {
                        //nums.Insert(after, nums[after - 1]);
                        //nums.Insert(after - 1, nums[after]);

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
