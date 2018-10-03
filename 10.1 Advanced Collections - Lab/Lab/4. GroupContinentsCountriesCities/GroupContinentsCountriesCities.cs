using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.GroupContinentsCountriesCities
{
    class GroupContinentsCountriesCities
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();

                var continent = line[0];
                var country = line[1];
                var town = line[2];

                Add(result, continent, country, town);
            }

            Print(result);
        }

        private static void Print(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> result)
        {
            foreach (var cont in result.Keys)
            {
                Console.WriteLine("{0}:", cont);

                foreach (var countr in result[cont])
                {
                    Console.WriteLine("  {0} -> {1}", countr.Key, string.Join(", ", countr.Value));
                }
            }
        }

        private static void Add(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> result, string continent, string country, string town)
        {
            if (!result.ContainsKey(continent))
            {
                result[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!result[continent].ContainsKey(country))
            {
                result[continent][country] = new SortedSet<string>();
            }
            result[continent][country].Add(town);
        }
    }
}
