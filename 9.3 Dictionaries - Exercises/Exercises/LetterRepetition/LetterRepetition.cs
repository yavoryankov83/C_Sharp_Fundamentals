using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            var result = new Dictionary<char, int>();

            foreach (char letter in str)
            {
                if (!result.ContainsKey(letter))
                {
                    result[letter] = 0;
                }

                result[letter]++;
            }

            foreach (var letter in result)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }

        }
    }
}
