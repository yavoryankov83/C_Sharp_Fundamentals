using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split(' ').ToList();

            var initial = int.Parse(commands[0]);

            var result = commands
                .Skip(1)
                .ToList();

            for (int i = 0; i < result.Count / 2; i++)
            {
                var first = result[i + i];
                var second = int.Parse(result[i + 1 + i]);

                if (first == "up")
                {
                    initial += second;
                }
                else if (first == "down")
                {
                    initial -= second;
                }

                if (initial <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            Console.WriteLine($"got through safely. current altitude: {initial}m");
        }
    }
}
