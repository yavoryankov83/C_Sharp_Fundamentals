using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var result = new SortedDictionary<int, int>();

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (var num in nums)
            {
                if (!result.ContainsKey(num))
                {
                    result[num] = 0;
                }
                result[num]++;
            }

            foreach (var res in result)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
