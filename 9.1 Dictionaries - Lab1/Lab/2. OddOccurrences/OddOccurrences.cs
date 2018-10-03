using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');

            var result = new Dictionary<string, int>();

            var list = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!result.ContainsKey(words[i]))
                {
                    result.Add(words[i], 0);
                }

                result[words[i]]++;
            }

            foreach (var pair in result)
            {
                if (pair.Value % 2 == 1)
                {
                    list.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
