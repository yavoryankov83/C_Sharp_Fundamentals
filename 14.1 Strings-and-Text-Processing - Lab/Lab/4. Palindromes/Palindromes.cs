using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var input = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions
                .RemoveEmptyEntries);

            foreach (var word in input)
            {
                var reversed = new string(word.Reverse().ToArray());

                if (word == reversed)
                {
                    result.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", result.OrderBy(s => s).Distinct()));
        }
    }
}
