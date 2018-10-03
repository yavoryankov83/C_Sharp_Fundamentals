using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var count = int.Parse(Console.ReadLine());

            var moneySpend = 0.0;

            for (int i = 0; i < count; i++)
            {
                var item = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                moneySpend += (itemPrice * itemCount);

                if (itemCount > 1)
                {
                    item = $"{item}s";
                }

                Console.WriteLine($"Adding {itemCount} {item} to cart.");
            }
            Console.WriteLine($"Subtotal: ${moneySpend:F2}");

            if (budget >= moneySpend)
            {
                Console.WriteLine($"Money left: ${budget - moneySpend:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget - moneySpend):F2} more.");
            }
        }
    }
}
