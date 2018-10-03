using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DictRefAdvanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, List<int>>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var formated = line.Split(new char[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var name = formated[0];

                for (int i = 1; i < formated.Length; i++)
                {
                    var values = -1;

                    if (int.TryParse(formated[i], out values))
                    {
                        if (!result.ContainsKey(name))
                        {
                            result[name] = new List<int>();
                        }

                        result[name].Add(values);
                    }
                    else
                    {
                        var temp = formated[i];

                        if (result.ContainsKey(temp))
                        {
                            if (!result.ContainsKey(name))
                            {
                                result[name] = new List<int>();
                            }
                            result[name] =  new List<int>(result[temp]);
                            break;
                        }
                    }
                }

                line = Console.ReadLine();
            }
            foreach (var name in result)
            {
                Console.WriteLine($"{name.Key} === {string.Join(", ", name.Value)}");
            }
        }
    }   
}
