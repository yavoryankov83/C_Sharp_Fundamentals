using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.KeyKeyValueValue
{
    class KeyKeyValueValue
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, List<string>>();

            var key = Console.ReadLine();
            var value = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { " => " }, StringSplitOptions
                    .RemoveEmptyEntries);

                var keys = input[0];
                var values = input[1].Split(';');

                if (!result.ContainsKey(keys))
                {
                    result.Add(keys, new List<string>());
                }

                foreach (var item in values)
                {
                    result[keys].Add(item);
                }
            }

            foreach (var pairs in result)
            {
                if (pairs.Key.Contains(key))
                {
                    Console.WriteLine($"{pairs.Key}:");

                    foreach (var item in pairs.Value)
                    {
                        if (item.Contains(value))
                        {
                            Console.WriteLine($"-{item}");
                        }
                    }
                }        
            }
        }
    }
}
