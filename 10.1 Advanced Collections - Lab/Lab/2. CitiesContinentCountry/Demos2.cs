using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CitiesContinentCountry
{
    class Demos2
    {
        static void Main(string[] args)
        {
            var population = new Dictionary<string, Dictionary<string, int>>();

            //add country
            population["Bulgaria"] = new Dictionary<string, int>();

            //add towns
            population["Bulgaria"]["Sofia"] = 1800000;
            population["Bulgaria"]["Plovdiv"] = 1500000;

            population["Germany"] = new Dictionary<string, int>();
            population["Germany"]["Berlin"] = 1540000;
            population["Germany"]["Hamburg"] = 1200000;

            AddPopulation(population, "USA", "New York", 1508000);

            //delete town
            population["Bulgaria"].Remove("Plovdiv");

            //delete country
            population.Remove("Germany");


            //print
            foreach (var country in population.Keys)
            {
                Console.WriteLine(country);

                foreach (var town in population[country].Keys)
                {
                    Console.WriteLine($"{town} -> {population[country][town]}");
                }
            }
        }

        private static void AddPopulation(Dictionary<string, Dictionary<string, int>> population, string country, string town, int people)
        {
            if (! population.ContainsKey(country))
            {
                population[country] = new Dictionary<string, int>();
            }

            population[country][town] = people;
        }
    }
}
