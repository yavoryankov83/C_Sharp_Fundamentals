using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListHalf
{
    class TearListHalf
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var lower = new List<int>();
            var upper = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (i < nums.Count / 2)
                {
                    lower.Add(nums[i]);
                }
                else
                {
                    upper.Add(nums[i]);
                }
            }
            var index = 0;

            for (int i = 0; i < upper.Count; i++)
            {
                var digit1 = upper[i] / 10;
                var digit2 = upper[i] % 10;
                
                lower.Insert(index, digit1);
                lower.Insert(index + 2, digit2);
                index += 3;
            }
            Console.WriteLine(string.Join(" ", lower));
        }
    }
}
