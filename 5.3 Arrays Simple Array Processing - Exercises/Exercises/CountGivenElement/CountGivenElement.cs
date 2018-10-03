using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountGivenElement
{
    class CountGivenElement
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
