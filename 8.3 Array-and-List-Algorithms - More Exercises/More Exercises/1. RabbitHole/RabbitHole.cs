using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.RabbitHole
{
    class RabbitHole
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var energyCount = int.Parse(Console.ReadLine());

            var startIndex = 0;
            var isDead = false;

            while (energyCount > 0)
            {
                isDead = false;
                var command = input[startIndex].Split('|');

                var com1 = command[0];

                if (com1 == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                var com2 = int.Parse(command[1]);

                switch (com1)
                {
                    case "Left":
                        startIndex = Math.Abs(startIndex - com2) % input.Count;
                        energyCount -= com2;
                        break;

                    case "Right":
                        startIndex = (startIndex + com2) % input.Count;
                        energyCount -= com2;
                        break;

                    case "Bomb":
                        input.RemoveAt(startIndex);
                        startIndex = 0;
                        energyCount -= com2;
                        isDead = true;
                        break;
                }

                if (input[input.Count - 1] != "RabbitHole")
                {
                    input.RemoveAt(input.Count - 1);
                }
                input.Add("Bomb|" + energyCount);

                if (energyCount <= 0 && isDead)
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                }
                else if (energyCount <= 0 && !isDead)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                }
            }
        }
    }
}
