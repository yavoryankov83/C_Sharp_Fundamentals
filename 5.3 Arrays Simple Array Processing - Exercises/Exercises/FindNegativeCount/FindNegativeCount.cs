using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNegativeCount
{
    class FindNegativeCount
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var nums = new int[n];
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

                if (nums[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
