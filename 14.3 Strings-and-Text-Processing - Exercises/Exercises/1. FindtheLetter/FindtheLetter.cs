using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FindtheLetter
{
    class FindtheLetter
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var tokens = Console.ReadLine().Split(' ');

            var letter = tokens[0];
            var count = int.Parse(tokens[1]);

            var index = input.IndexOf(letter);
            var occurences = 1;

            while (true)
            {
                if (occurences == count)
                {
                    Console.WriteLine(index);
                    return;
                }

                occurences++;
                index = input.IndexOf(letter, index + 1);

                if (index == -1)
                {
                    break;
                }
            }
            Console.WriteLine("Find the letter yourself!");
        }
    }
}
