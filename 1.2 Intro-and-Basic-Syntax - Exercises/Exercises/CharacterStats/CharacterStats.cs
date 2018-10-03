using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            var health = maximumHealth - currentHealth;
            var energy = maximumEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', currentHealth)}{new string('.', health)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.', energy)}|");
        }
    }
}
