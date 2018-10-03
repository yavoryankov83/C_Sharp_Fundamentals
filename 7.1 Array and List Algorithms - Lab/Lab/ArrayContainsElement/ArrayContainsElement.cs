using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var n = int.Parse(Console.ReadLine());

            var found = false;

            foreach (var num in nums)
            {
                if (num == n)
                {
                    found = true;

                    Console.WriteLine("yes");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
