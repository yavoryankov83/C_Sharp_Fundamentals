using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');

            var rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var index = rnd.Next(0, words.Length);

                var temp = words[index];
                words[index] = words[i];
                words[i] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
