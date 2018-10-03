using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CountofOddNumbersinArray
{
    class CountofOddNumbersinArray
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = nums
                .Where(n => n % 2 != 0)
                .Count();

            Console.WriteLine(count);
        }
    }
}
