using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, HashSet<int>>();

            var input = Console.ReadLine();

            while (input != "Aggregate")
            {
                var tokens = input.Split(' ');

                var name = tokens[0];
                var count = int.Parse(tokens[1]);

                if (!result.ContainsKey(name))
                {
                    result.Add(name, new HashSet<int>());
                }
                result[name].Add(count);

                input = Console.ReadLine();
            }

            foreach (var pair in result)
            {
                var name = pair.Key;
                var counts = pair.Value;

                var sum = counts.Sum();
                var average = (int)counts.Average();

                var giant = sum - average;

                Console.WriteLine($"{name} -> {string.Join(", ", counts)} ({giant})");
            }
        }
    }
}
