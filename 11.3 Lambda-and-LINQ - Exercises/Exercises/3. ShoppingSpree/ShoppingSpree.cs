using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, decimal>();

            var budget = decimal.Parse(Console.ReadLine());

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(' ');

                var productName = tokens[0];
                var productPrice = decimal.Parse(tokens[1]);

                if (!result.ContainsKey(productName))
                {
                    result.Add(productName, productPrice);
                }

                else
                {
                    if (result[productName] > productPrice)
                    {
                        result[productName] = productPrice;
                    }
                }

                input = Console.ReadLine();
            }

            var sum = result.Values.Sum();

            if (sum > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                foreach (var pair in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{pair.Key} costs {pair.Value:F2}");
                }
            }
        }
    }
}
