using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var numns = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var result = new SortedDictionary<double, int>();

            foreach (var num in numns)
            {
                if (!result.ContainsKey(num))
                {
                    result[num] = 0;
                }

                result[num]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }
        }
    }
}
