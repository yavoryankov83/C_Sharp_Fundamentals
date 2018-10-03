using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.GroupContinentsCountriesandCities
{
    class GroupContinentsCountriesandCities
    {
        static void Main(string[] args)
        {
            var result = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!result.ContainsKey(continent))
                {
                    result.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                }
                if (!result[continent].ContainsKey(country))
                {
                    result[continent].Add(country, new SortedSet<string>());
                }

                result[continent][country].Add(city);
            }

            foreach (var pair in result)
            {
                var continent = pair.Key;
                var countryAndCity = pair.Value;

                Console.WriteLine($"{continent}:");

                foreach (var pair2 in countryAndCity)
                {
                    var country = pair2.Key;
                    var city = pair2.Value;

                    Console.WriteLine($"    {country} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}
