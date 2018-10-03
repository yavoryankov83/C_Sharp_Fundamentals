using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main(string[] args)
        {
            var koordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(' ').ToList();

            var x = 0;
            var y = 0;

            for (int i = 0; i < commands.Count / 2; i++)
            {
                var com = commands[i + i];
                var digit = int.Parse(commands[i + 1 + i]);

                if (com == "up")
                {
                    y += digit;
                }
                else if (com == "down")
                {
                    y -= digit;
                }
                else if (com == "left")
                {
                    x -= digit;
                }
                else if (com == "right")
                {
                    x += digit;
                }
            }
            Console.WriteLine($"firing at [{x}, {y}]");

            if (x == koordinates[0] && y == koordinates[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
