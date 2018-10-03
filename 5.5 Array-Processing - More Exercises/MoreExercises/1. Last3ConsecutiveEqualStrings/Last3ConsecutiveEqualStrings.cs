using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Last3ConsecutiveEqualStrings
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main(string[] args)
        {
            var count = 1;

            var line = Console.ReadLine().Split(' ').ToList();

            for (int i = line.Count - 1; i > 0; i--)
            {
                var current = line[i];
                var next = line[i - 1];

                if (next == current)
                {
                    count++;

                    if (count == 3)
                    {
                        Console.WriteLine($"{current} {current} {current}");
                        break;
                    }
                }
                else
                {
                    count = 1;
                }
            }
        }
    }
}
