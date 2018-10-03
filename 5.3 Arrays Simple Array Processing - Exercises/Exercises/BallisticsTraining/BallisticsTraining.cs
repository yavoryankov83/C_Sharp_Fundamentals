using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main(string[] args)
        {
            var cordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            var x = 0;
            var y = 0;

            var directions = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == "up")
                {
                    y += Convert.ToInt32(directions[i + 1]);
                }
                else if (directions[i] == "down")
                {
                    y -= Convert.ToInt32(directions[i + 1]);
                }
                else if (directions[i] == "left")
                {
                    x -= Convert.ToInt32(directions[i + 1]);
                }
                else if (directions[i] == "right")
                {
                    x += Convert.ToInt32(directions[i + 1]);
                }
            }
            Console.WriteLine($"firing at [{x}, {y}]");

            if (x == cordinates[0] && y == cordinates[1])
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
