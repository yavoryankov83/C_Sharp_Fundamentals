using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole
{
    class RabbitHole
    {
        static void Main(string[] args)
        {
            var obstacles = Console.ReadLine().Split(' ').ToList();
            var energy = int.Parse(Console.ReadLine());

            var currentIndex = 0;
            var lastBomb = false;

            while (energy > 0)
            {
                var commandParams = obstacles[currentIndex].Split('|');

                var currentCommand = commandParams[0];
                lastBomb = false;

                if (currentCommand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }

                var value = int.Parse(commandParams[1]);

                switch (currentCommand)
                {
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - value) % obstacles.Count;
                        energy -= value;
                        break;
                    case "Right":
                        currentIndex = (currentIndex + value) % obstacles.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        obstacles.RemoveAt(currentIndex);
                        currentIndex = 0;
                        energy -= value;
                        lastBomb = true;
                        break;
                }

                if (obstacles[obstacles.Count - 1] != "RabbitHole")
                {
                    obstacles.RemoveAt(obstacles.Count - 1);
                }

                obstacles.Add("Bomb|" + energy);
            }

            if (energy <= 0 && lastBomb)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else if(energy <= 0 && !lastBomb)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
        }
    }
}
