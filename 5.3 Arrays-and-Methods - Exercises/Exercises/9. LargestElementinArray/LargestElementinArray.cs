using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.LargestElementinArray
{
    class LargestElementinArray
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var nums = int.Parse(Console.ReadLine());

                if (nums > max)
                {
                    max = nums;
                }
            }
            Console.WriteLine(max);
        }
    }
}
