using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');

            var sum = 0;
            var count = 0;

            foreach (var word in words)
            {
                foreach (char letter in word)
                {
                    sum += (int)letter;
                    count++;
                }
            }

            var character = (char)(sum / count);
            var delimeter = char.ToUpper(character);

            for (int i = 0; i < words.Length; i++)
            {
                if (i == words.Length -1)
                {
                    Console.Write(words[i]);
                }
                else
                {
                    Console.Write(words[i] + delimeter);
                }
            }
            Console.WriteLine();
        }
    }
}
