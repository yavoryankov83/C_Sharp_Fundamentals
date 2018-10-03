using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            var sentences = new List<string>();

            var input = Console.ReadLine();
            var delimeter = new char[] { '-', ' ', '.', ',', '!', '?', ':', ';', '"', '\n', ']', '[', '{', '}' };

            while (input != "end")
            {
                var tokens = input
                    .Split(delimeter,StringSplitOptions
                    .RemoveEmptyEntries);

                foreach (var word in tokens)
                {
                    var result1 = char.ToUpper(word.First());
                    var result2 = word.Substring(1).ToLower();
                    var result = result1 + result2;

                    sentences.Add(result);
                }

                Console.WriteLine(string.Join(", ", sentences));

                sentences.Clear();

                input = Console.ReadLine();
            }
        }
    }
}
