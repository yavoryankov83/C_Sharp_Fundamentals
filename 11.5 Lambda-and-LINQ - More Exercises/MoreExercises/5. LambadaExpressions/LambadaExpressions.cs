using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.LambadaExpressions
{
    class LambadaExpressions
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, string>>();

            var input = Console.ReadLine();

            while (input != "lambada")
            {
                var tokens = input
                    .Split(new string[] { " => ", "." }, StringSplitOptions
                    .RemoveEmptyEntries);

                if (tokens[0] == "dance")
                {
                    //result = result
                    //    .ToDictionary(a => a.Key, a => a.Value
                    //    .ToDictionary(b => b.Key, b => b.Key + "." + b.Value));
                    var keys = result.Keys.ToList();

                    foreach (var key in keys)
                    {
                        var innerKeys = result[key].Keys.ToList();

                        foreach (var innerKey in innerKeys)
                        {
                            result[key][innerKey] = innerKey + "." + result[key][innerKey];
                        }
                    }
                }
                else
                {
                    var selector = tokens[0];
                    var selectorObject = tokens[1];
                    var property = tokens[2];

                    if (!result.ContainsKey(selector))
                    {
                        result.Add(selector, new Dictionary<string, string>());
                    }
                    result[selector][selectorObject] = property;
                }

                input = Console.ReadLine();
            }

            foreach (var pair in result)
            {
                var selector = pair.Key;
                var selectorObjectAndProperty = pair.Value;

                foreach (var pair2 in selectorObjectAndProperty)
                {
                    var selectorObject = pair2.Key;
                    var property = pair2.Value;

                    Console.WriteLine($"{selector} => {selectorObject}.{property}");
                }
            }
        }
    }
}
