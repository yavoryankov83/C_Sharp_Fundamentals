using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();
            var count = 0.0;

            var input = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result[input[i]] = 0;
                }
                result[input[i]]++;
            }

            var resultNew = result.OrderByDescending(a => a.Value);

            foreach (var item in result.Values)
            {
                count += item;
            } 

            foreach (var item in resultNew)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times ({(item.Value / count).ToString("0.00%")})");
            }
        }
    }
}
