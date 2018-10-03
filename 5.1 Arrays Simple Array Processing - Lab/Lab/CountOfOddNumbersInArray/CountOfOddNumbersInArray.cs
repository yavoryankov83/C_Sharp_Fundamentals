using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfOddNumbersInArray
{
    class CountOfOddNumbersInArray
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
