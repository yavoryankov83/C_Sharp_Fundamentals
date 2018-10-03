using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToList();

            var result = new Dictionary<string, int>();

            var final = new List<string>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }

                result[word]++;
            }

            foreach (var item in result)
            {
                if (item.Value % 2 != 0)
                {
                    final.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", final));
        }
    }
}
