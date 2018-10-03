using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementArray
{
    class SmallestElementArray
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var smallestElement = int.MaxValue;

            foreach (var num in nums)
            {
                if (num < smallestElement)
                {
                    smallestElement = num;
                }
            }
            Console.WriteLine(smallestElement);
        }
    }
}
