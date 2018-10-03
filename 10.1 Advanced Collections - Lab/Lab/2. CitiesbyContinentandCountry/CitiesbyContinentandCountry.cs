using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CitiesbyContinentandCountry
{
    class CitiesbyContinentandCountry
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var towns = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');

                var continent = line[0];
                var country = line[1];
                var town = line[2];

                AddTown(towns, continent, country, town);
            }

            PrintTown(towns);
        }

        private static void PrintTown(Dictionary<string, Dictionary<string, List<string>>> towns)
        {
            foreach (var continent in towns.Keys)
            {
                Console.WriteLine("{0}:", continent);

                foreach (var country in towns[continent])
                {
                    Console.WriteLine("  {0} -> {1}", country.Key, string.Join(", ", country.Value));
                }
            }
        }

        private static void AddTown(Dictionary<string, Dictionary<string, List<string>>> towns, string continent, string country, string town)
        {
            if (!towns.ContainsKey(continent))
            {
                towns[continent] = new Dictionary<string, List<string>>();
            }

            if (!towns[continent].ContainsKey(country))
            {
                towns[continent][country] = new List<string>();
            }

            towns[continent][country].Add(town);
        }
    }
}
