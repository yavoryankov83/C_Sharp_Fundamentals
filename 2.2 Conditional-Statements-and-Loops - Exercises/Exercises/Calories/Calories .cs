using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories
{
    class Calories
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var calories = 0;
            var result = 0;

            var cheeseCount = 0;
            var tomatoCount = 0;
            var salamiCount = 0;
            var pepperCount = 0;

            for (int i = 0; i < n; i++)
            {
                var ingredients = Console.ReadLine().ToLower();
                
                switch (ingredients)
                {
                    case "cheese":
                        calories = 500;
                        cheeseCount ++;
                        break;
                    case "tomato sauce":
                        calories = 150;
                        tomatoCount++;
                        break;
                    case "salami":
                        calories = 600;
                        salamiCount++;
                        break;
                    case "pepper":
                        calories = 50;
                        pepperCount++;
                        break;
                    default:
                        calories = 0;
                        break;
                }

                result += calories;

                //if (cheeseCount == 2 || tomatoCount == 2 || salamiCount == 2 || pepperCount == 2)
                //{
                //    return;
                //}
            }

            Console.WriteLine($"Total calories: {result}");
        }
    }
}
