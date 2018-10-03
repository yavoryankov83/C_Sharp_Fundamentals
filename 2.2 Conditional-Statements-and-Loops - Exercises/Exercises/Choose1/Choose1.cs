using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose1
{
    class Choose1
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var drink = "";
            var price = 0.0;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    price = 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    price = 1;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    price = 1.7;
                    break;
                default:
                    drink = "Tea";
                    price = 1.2;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {price * quantity:F2}.");
        }
    }
}
