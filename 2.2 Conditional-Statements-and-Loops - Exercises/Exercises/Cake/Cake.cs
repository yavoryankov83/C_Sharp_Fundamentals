using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine();
            var count = 0;

            while (ingredients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                count++;

                ingredients = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
