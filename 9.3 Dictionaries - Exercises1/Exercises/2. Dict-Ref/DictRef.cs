using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Dict_Ref
{
    class DictRef
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(' ');

                var name1 = tokens[0];

                string name2 = tokens[2];
                int value;

                var parced = int.TryParse(name2, out value);

                if (parced)
                {
                    if (!result.ContainsKey(name1))
                    {
                        result.Add(name1, value);
                    }
                    else
                    {
                        result[name1] = value;
                    }
                }
                else
                {
                    if (result.ContainsKey(name2))
                    {
                        if (!result.ContainsKey(name1))
                        {
                            result.Add(name1, result[name2]);
                        }
                        else
                        {
                            result[name1] = result[name2];
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} === {pair.Value}");
            }
        }
    }
}
