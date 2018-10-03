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
            var line = Console.ReadLine().Split(' ').ToList();

            var random = new Random();

            for (int i = 0; i < line.Count; i++)
            {
                var current = line[i];
                var randomPosition = random.Next(0, line.Count);

                var temp = line[randomPosition];
                line[randomPosition] = current;
                line[i] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, line));
        }
    }
}
