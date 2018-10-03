using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            var result = new SortedDictionary<string, decimal>();

            var input = Console.ReadLine();

            while (input != "Over")
            {
                var tokens = input.Split(' ');

                var name = tokens[0];
                var phone = tokens[2];

                if (!char.IsDigit(name[0]))
                {
                    if (!result.ContainsKey(name))
                    {
                        result.Add(name, decimal.Parse(phone));
                    }
                }
                else
                {
                    if (!result.ContainsKey(phone))
                    {
                        if (!result.ContainsKey(phone))
                        {
                            result.Add(phone, decimal.Parse(name));
                        }
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
