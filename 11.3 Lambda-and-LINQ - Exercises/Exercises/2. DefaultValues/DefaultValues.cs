using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DefaultValues
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, string>();

            var firstPart = new Dictionary<string, string>();
            var secondPart = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions
                    .RemoveEmptyEntries);

                var key = tokens[0];
                var value = tokens[1];

                if (!result.ContainsKey(key))
                {
                    result.Add(key, value);
                }

                result[key] = value;

                input = Console.ReadLine();
            }

            var defaultValue= Console.ReadLine();

            foreach (var pair in result)
            {
                if (pair.Value == "null")
                {
                    firstPart.Add(pair.Key, defaultValue);
                }
                else
                {
                    secondPart.Add(pair.Key, pair.Value);
                }
            }

            foreach (var pair in secondPart.OrderByDescending(s => s.Value.Length))
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");
            }

            foreach (var pair in firstPart)
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");
            }
        }
    }
}
