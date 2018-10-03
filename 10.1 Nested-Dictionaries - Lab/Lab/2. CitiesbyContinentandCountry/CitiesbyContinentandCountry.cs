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
            var result = new Dictionary<string, Dictionary<string, List<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!result.ContainsKey(continent))
                {
                    result.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!result[continent].ContainsKey(country))
                {
                    result[continent].Add(country, new List<string>());
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
                    var cities = pair2.Value;

                    Console.WriteLine($"    {country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
