using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            var cash = double.Parse(Console.ReadLine());
            var numberOfGuests = int.Parse(Console.ReadLine());
            var bananasPrice = double.Parse(Console.ReadLine());
            var eggsPrice = double.Parse(Console.ReadLine());
            var berriesPrice = double.Parse(Console.ReadLine());

            var portionsSets = Math.Ceiling(numberOfGuests / 6.0);

            var priceForSetOf6 = (2 * bananasPrice) + (4 * eggsPrice) + (0.2 * berriesPrice);

            var calculetedPrice = portionsSets * priceForSetOf6;

            if (calculetedPrice > cash)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(calculetedPrice - cash):F2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {calculetedPrice:F2}lv.");
            }
        }
    }
}
