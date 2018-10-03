using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ArrayElementsEqualtoTheirIndex
{
    class ArrayElementsEqualtoTheirIndex
    {
        static void Main(string[] args)
        {
            var result = new List<int>();

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums[i])
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
