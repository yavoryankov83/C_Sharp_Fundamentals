using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.RemoveNegativesandReverse
{
    class RemoveNegativesandReverse
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = nums
                .Where(n => n > 0)
                .Reverse()
                .ToList();

            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
