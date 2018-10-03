using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TearListinHalf
{
    class TearListinHalf
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var line1 = line
                .Skip(line.Count / 2)
                .ToList();

            var line2 = line
                .Take(line.Count / 2)
                .ToList();

            var pow = 0;

            for (int i = 0; i < line1.Count; i++)
            {
                var firstDigit = line1[i] / 10;
                var secondDigit = line1[i] % 10;

                line2.Insert(pow, firstDigit);
                line2.Insert(pow + 2, secondDigit);

                pow += 3;
            }

            Console.WriteLine(string.Join(" ", line2));
        }
    }
}
