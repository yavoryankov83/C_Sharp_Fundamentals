using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CountofNegativeElementsinArray
{
    class CountofNegativeElementsinArray
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var nums = int.Parse(Console.ReadLine());
                result.Add(nums);
            }

            var count = result
                .Count(num => num < 0);

            Console.WriteLine(count);
        }
    }
}
