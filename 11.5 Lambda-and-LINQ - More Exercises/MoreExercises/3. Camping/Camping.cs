using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Camping
{
    class Camping
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(' ');

                var name = tokens[0];
                var camper = tokens[1];
                var nightsCount = int.Parse(tokens[2]);

                if (!result.ContainsKey(name))
                {
                    result.Add(name, new Dictionary<string, int>());
                }

                if (!result[name].ContainsKey(camper))
                {
                    result[name].Add(camper, nightsCount);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in result.OrderByDescending(x => x.Value.Count()).ThenBy(s => s.Key.Length))
            {
                var name = pair.Key;
                var camperAndNightsCount = pair.Value;

                Console.WriteLine($"{name}: {result[name].Count}");

                var sum = camperAndNightsCount.Values.Sum();

                foreach (var pair2 in camperAndNightsCount)
                {
                    var camper = pair2.Key;
                    var nightsCount = pair2.Value;

                    Console.WriteLine($"***{camper}");
                }
                Console.WriteLine($"Total stay: {sum} nights");
            }
        }
    }
}
