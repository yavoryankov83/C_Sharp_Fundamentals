using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLargerNumbers
{
    class CountLargerNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > p)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
