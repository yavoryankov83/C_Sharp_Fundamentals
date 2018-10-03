using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<char, int>();

            var line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                var currentChar = line[i];

                if (!result.ContainsKey(currentChar))
                {
                    result.Add(currentChar, 0);
                }

                result[currentChar]++;
            }

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
