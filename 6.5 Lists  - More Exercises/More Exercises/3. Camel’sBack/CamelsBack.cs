using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Camel_sBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var camelBackSize = int.Parse(Console.ReadLine());

            var count = 0;

            if (nums.Count == camelBackSize)
            {
                Console.WriteLine($"already stable: " + string.Join(" ", nums));
                return;
            }

            while (nums.Count > camelBackSize)
            {
                nums.RemoveAt(0);
                nums.RemoveAt(nums.Count - 1);

                count++;
            }

            Console.WriteLine($"{count} rounds");
            Console.WriteLine("remaining: " + string.Join(" ", nums));
        }
    }
}
