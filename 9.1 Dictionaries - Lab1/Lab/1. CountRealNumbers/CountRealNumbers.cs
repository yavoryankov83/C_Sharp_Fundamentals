using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var result = new SortedDictionary<double, int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (!result.ContainsKey(nums[i]))
                {
                    result.Add(nums[i], 0);
                }

                result[nums[i]]++;
            }

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
