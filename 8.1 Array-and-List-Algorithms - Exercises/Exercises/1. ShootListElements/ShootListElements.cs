using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShootListElements
{
    class ShootListElements
    {
        static void Main(string[] args)
        {
            var result = new List<int>();

            var lastRemoved = -1;

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var line = input;

                if (line == "bang")
                {
                    if (result.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemoved}");
                        return;
                    }
                    var average = result.Average();

                    var removed = result
                        .FirstOrDefault(x => x <= average);

                    lastRemoved = removed;

                    result.Remove(removed);

                    Console.WriteLine($"shot {removed}");

                    result = result.Select(x => x = x - 1).ToList();
                }
                else
                {
                    result.Insert(0, int.Parse(line));
                }

                input = Console.ReadLine();
            }

            if (result.Count == 0)
            {
                Console.WriteLine($"you shot them all. last one was {lastRemoved}");
            }
            else
            {
                Console.WriteLine($"survivors: {string.Join(" ", result)}");
            }
        }
    }
}
