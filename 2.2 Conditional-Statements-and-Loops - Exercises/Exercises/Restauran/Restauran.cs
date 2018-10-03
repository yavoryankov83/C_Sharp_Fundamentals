using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauran
{
    class Restauran
    {
        static void Main(string[] args)
        {
            var peopleCount = int.Parse(Console.ReadLine());
            var packageType = Console.ReadLine();

            var type = "";
            var price = 0;
            var discount = 0.0;

            if (peopleCount <= 50)
            {
                type = "Small Hall";
                price = 2500;
            }
            else if (peopleCount > 50 && peopleCount <= 100)
            {
                type = "Terrace";
                price = 5000;
            }
            else if (peopleCount > 100 && peopleCount <= 120)
            {
                type = "Great Hall";
                price = 7500;
            }
            else if (peopleCount > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (packageType == "Normal")
            {
                price += 500;
                discount = 0.05;
            }
            else if (packageType == "Gold")
            {
                price += 750;
                discount = 0.1;
            }
            else if (packageType == "Platinum")
            {
                price += 1000;
                discount = 0.15;
            }

            var discountPrice = price - (price * discount);
            
            Console.WriteLine($"We can offer you the {type}");
            Console.WriteLine($"The price per person is {discountPrice / peopleCount:F2}$");
        }
    }
}
