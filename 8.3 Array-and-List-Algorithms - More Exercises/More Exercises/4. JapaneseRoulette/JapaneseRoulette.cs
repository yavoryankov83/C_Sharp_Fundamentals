using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.JapaneseRoulette
{
    class JapaneseRoulette
    {
        static void Main(string[] args)
        {
            var cilinderHoles = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var valueAndDirection = Console.ReadLine()
                .Split(' ');

            var bullet = cilinderHoles.IndexOf(1);

            var isDead = false;

            var playerNumber = 0;


            for (int i = 0; i < valueAndDirection.Length; i++)
            {
                var round = valueAndDirection[i].Split(',');

                var strenght = int.Parse(round[0]);
                var direction = round[1];
                playerNumber = i;

                if (direction == "Right")
                {
                    bullet = (bullet + strenght) % cilinderHoles.Count;
                }
                else if (direction == "Left")
                {
                    bullet = (Math.Abs(bullet - strenght)) % cilinderHoles.Count;
                    if (bullet < 0)
                    {
                        bullet += cilinderHoles.Count;
                    }
                }

                if (bullet == 2)
                {
                    isDead = true;
                    break;
                }

                bullet++;
            }

            if (isDead)
            {
                Console.WriteLine($"Game over! Player {playerNumber} is dead.");
            }
            else
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
