using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrayElements
{
    class SumArrayElements
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var nums = new int[number];
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

                sum += nums[i];
            }

            Console.WriteLine(sum);
        }
    }
}
