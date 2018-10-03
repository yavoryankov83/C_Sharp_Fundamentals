using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, HashSet<int>>();

            var line = Console.ReadLine();

            while (line != "Aggregate")
            {
                var formatedLine = line.Split();

                var town = formatedLine[0];
                var count = int.Parse(formatedLine[1]);
                AddToResult(result, town, count);

                line = Console.ReadLine();
            }

            PrintResult(result);
        }

        private static void PrintResult(Dictionary<string, HashSet<int>> result)
        {
            foreach (var town in result)
            {
                var giant = town.Value.Sum() - town.Value.Average();
                Console.WriteLine($"{town.Key} -> {string.Join(", ", town.Value)} ({giant:F0})");
            }
        }

        private static void AddToResult(Dictionary<string, HashSet<int>> result, string town, int count)
        {
            if (!result.ContainsKey(town))
            {
                result[town] = new HashSet<int>();
            }

            result[town].Add(count);
        }
    }
}
