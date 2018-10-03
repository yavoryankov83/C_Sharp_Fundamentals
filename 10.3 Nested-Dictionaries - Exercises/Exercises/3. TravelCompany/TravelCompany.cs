using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TravelCompany
{
    class TravelCompany
    {
        static void Main(string[] args)
        {
            //var result = new Dictionary<string, Dictionary<string, int>>();
            //var result1 = new Dictionary<string, int>();

            //var input = Console.ReadLine();

            //while (input != "ready")
            //{
            //    var tokens = input.Split(':');

            //    var cities = tokens[0];
            //    var typeAndCapasity = tokens[1].Split(',');

            //    foreach (var item in typeAndCapasity)
            //    {
            //        var pair = item.Split('-');

            //        var type = pair[0];
            //        var capacity = int.Parse(pair[1]);

            //        if (!result.ContainsKey(cities))
            //        {
            //            result.Add(cities, new Dictionary<string, int>());
            //        }
            //        if (!result[cities].ContainsKey(type))
            //        {
            //            result[cities].Add(type, capacity);
            //        }
            //        result[cities][type] = capacity;
            //    }

            //    input = Console.ReadLine();
            //}

            //var newInput = Console.ReadLine();

            //while (newInput != "travel time!")
            //{
            //    var tokens = newInput.Split(' ');

            //    var city = tokens[0];
            //    var peopleCount = int.Parse(tokens[1]);

            //    if (!result1.ContainsKey(city))
            //    {
            //        result1.Add(city, peopleCount);
            //    }

            //    newInput = Console.ReadLine();
            //}

            //foreach (var cities in result)
            //{
            //    foreach (var c in result1)
            //    {
            //        if (cities.Key == c.Key)
            //        {
            //            if (result[cities])
            //            {

            //            }
            //        }
            //    }
            //    var city = cities.Key;
            //    var typeAndCapacity = cities.Value;

            //    int sum = 0;

            //    foreach (var pair in typeAndCapacity)
            //    {
            //        var type = pair.Key;
            //        var capacity = pair.Value;

            //        sum += capacity;
            //    }

            //    if (result.ContainsKey())
            //    {

            //    }
            //}
            bool readyMode = false;
            var citiesAndTransport = new Dictionary<string, Dictionary<string, int>>();
            var citiesAndTourists = new Dictionary<string, int>();
            while (true)
            {
                string intro = Console.ReadLine();
                if (intro == "travel time!")
                    break;
                if (intro == "ready")
                {
                    readyMode = true;
                    continue;
                }
                if (readyMode == false)
                {
                    string city = intro.Split(':')[0];
                    string[] transports = intro.Split(':')[1].Split(',');
                    for (int br = 0; br < transports.Length; br++)
                    {
                        string vehicle = transports[br].Split('-')[0];
                        int capacity = int.Parse(transports[br].Split('-')[1]);
                        if (!citiesAndTransport.ContainsKey(city))
                            citiesAndTransport.Add(city, new Dictionary<string, int>());
                        if (!citiesAndTransport[city].ContainsKey(vehicle))
                            citiesAndTransport[city].Add(vehicle, capacity);
                        citiesAndTransport[city][vehicle] = capacity;
                    }
                }
                else
                {
                    string city = intro.Split(' ')[0];
                    int tourists = int.Parse(intro.Split(' ')[1]);
                    citiesAndTourists[city] = tourists;
                }
            }
            int touristsInCity, sumOfAllPlaces;
            foreach (var city in citiesAndTourists.Keys)
            {
                touristsInCity = sumOfAllPlaces = 0;
                touristsInCity = citiesAndTourists[city];
                foreach (var item in citiesAndTransport[city])
                {
                    sumOfAllPlaces = sumOfAllPlaces + item.Value;
                }
                if (sumOfAllPlaces >= touristsInCity)
                    Console.WriteLine($"{city} -> all {touristsInCity} accommodated");
                else if (sumOfAllPlaces < touristsInCity)
                    Console.WriteLine($"{city} -> all except {touristsInCity - sumOfAllPlaces} accommodated");
            }
        }
    }
}
