using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var initial = money;
            var command = Console.ReadLine();
            var price = 0d;



            while (command != "Game Time")
            {
                switch (command)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        command = Console.ReadLine();
                        continue;
                }

                if (money >= price)
                {
                    Console.WriteLine($"Bought {command}");
                    money -= price;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                if (money <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${initial - money:F2}. Remaining: ${money:F2}");
        }
    }
}
