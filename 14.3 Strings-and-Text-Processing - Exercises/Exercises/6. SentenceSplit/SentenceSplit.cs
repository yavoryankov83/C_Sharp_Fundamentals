using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SentenceSplit
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var input = Console.ReadLine();
            var delimeter = (Console.ReadLine());

            var splitted = input
                .Split(new string[] { delimeter}, StringSplitOptions
                .None);

            foreach (var word in splitted)
            {
                result.Add(word);
            }

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
