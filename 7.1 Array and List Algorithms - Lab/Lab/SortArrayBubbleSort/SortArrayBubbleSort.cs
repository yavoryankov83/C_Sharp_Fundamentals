using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayBubbleSort
{
    class SortArrayBubbleSort
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    var current = nums[i];
                    var next = nums[i + 1];

                    if (current > next)
                    {
                        nums[i] = next;
                        nums[i + 1] = current;

                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
