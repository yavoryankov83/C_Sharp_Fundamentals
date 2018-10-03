using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, int>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { " -> "}, StringSplitOptions.RemoveEmptyEntries);

                var colour = input[0];
                var clothes = input[1].Split(',');

                if (!result.ContainsKey(colour))
                {
                    result.Add(colour, new Dictionary<string, int>());
                }
               
                foreach (var cloth in clothes)
                {
                    var clothBase = result[colour];

                    if (!clothBase.ContainsKey(cloth))
                    {
                        clothBase.Add(cloth, 0);
                    }
                    clothBase[cloth]++;
                }
            }

            var searched = Console.ReadLine().Split(' ');

            var searchedColour = searched[0];
            var searchedCloth = searched[1];

            foreach (var colorData in result)
            {
                var colour = colorData.Key;
                var clothAndOccur = colorData.Value;

                Console.WriteLine($"{colour} clothes:");

                foreach (var clothAndCount in clothAndOccur)
                {
                    var cloth = clothAndCount.Key;
                    var count = clothAndCount.Value;

                    Console.Write($"* {cloth} - {count}");

                    if (cloth == searchedCloth && colour == searchedColour)
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
