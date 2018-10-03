using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage
{
    class Beverage
    {
        static void Main(string[] args)
        {
            var food = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            var perML = (volume / 100d);

            var energy = energyContent * perML;
            var sugar = sugarContent * perML;

            Console.WriteLine($"{volume}ml {food}: \n{energy}kcal, {sugar}g sugars");
        }
    }
}
