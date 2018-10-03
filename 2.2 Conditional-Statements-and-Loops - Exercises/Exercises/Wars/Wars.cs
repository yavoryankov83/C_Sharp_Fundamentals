using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wars
{
    class Wars
    {
        static void Main(string[] args)
        {
            var peshoDemage = int.Parse(Console.ReadLine());
            var goshoDemage = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;

            var peshoIsAlive = true;
            var goshoIsAlive = true;

            var count = 0;

            while (peshoIsAlive && goshoIsAlive)
            {
                count++;

                if (count % 2 == 1)
                {
                    goshoHealth -= peshoDemage;

                    if (goshoHealth <= 0 )
                    {
                        goshoIsAlive = false;
                        continue;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    peshoHealth -= goshoDemage;

                    if (peshoHealth <= 0)
                    {
                        peshoIsAlive = false;
                        continue;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                if (count % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }

            if (peshoIsAlive)
            {
                Console.WriteLine($"Pesho won in {count}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {count}th round.");
            }
        }
    }
}
