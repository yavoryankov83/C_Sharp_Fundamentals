using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, string>>();
            var flattened = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(' ');

                if (tokens[0] == "flatten")
                {
                    var keyToFlatten = tokens[1];

                    foreach (var pair in result)
                    {
                        var key = pair.Key;
                        var innerKeyAndValue = pair.Value;

                        if (key == keyToFlatten)
                        {
                            foreach (var pair2 in innerKeyAndValue)
                            {
                                var flattenedValue = pair2.Key + pair2.Value;

                                if (!flattened.ContainsKey(key))
                                {
                                    flattened.Add(key, new List<string>());
                                }

                                flattened[key].Add(flattenedValue);
                            }
                        }
                    }

                    result[keyToFlatten] = new Dictionary<string, string>();
                }

                else
                {
                    var key = tokens[0];
                    var innerKey = tokens[1];
                    var innerValue = tokens[2];

                    if (!result.ContainsKey(key))
                    {
                        result.Add(key, new Dictionary<string, string>());
                    }

                    if (!result[key].ContainsKey(innerKey))
                    {
                        result[key].Add(innerKey, "");
                    }

                    result[key][innerKey] = innerValue;
                }

                input = Console.ReadLine();
            }

            foreach (var pair in result.OrderByDescending(x => x.Key.Length))
            {
                var key = pair.Key;
                var innerKeyAndValue = pair.Value;

                Console.WriteLine($"{key}");

                var rang = 1;

                foreach (var pair2 in innerKeyAndValue.OrderBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{rang}. {pair2.Key} - {pair2.Value}");

                    rang++;
                }

                if (flattened.ContainsKey(key))
                {
                    foreach (var pair3 in flattened[key])
                    {
                        Console.WriteLine($"{rang}. {pair3}");

                        rang++;
                    }
                }
            }
        }
    }
}
