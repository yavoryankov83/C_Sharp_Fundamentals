using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StringDecryption
{
    class StringDecryption
    {
        static void Main(string[] args)
        {
            var message = string.Empty;

            var couple = Console.ReadLine().Split(' ');

            var skipped = int.Parse(couple[0]);
            var takened = int.Parse(couple[1]);

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            nums = nums
                .Where(x => x >= 65 && x <= 90)
                .Skip(skipped)
                .Take(takened)
                //.Distinct()
                .ToList();

            foreach (var num in nums)
            {
                message += (char)(num);
            }

            Console.WriteLine(message);
        }
    }
}
