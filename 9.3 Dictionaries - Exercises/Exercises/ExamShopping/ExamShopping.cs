using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var products = new SortedDictionary<string, int>();

            while (line != "shopping time")
            {
                var tokens = line.Split();

                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    products[product] = 0;
                }

                products[product] += quantity;

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line != "exam time")
            {
                var stock = line.Split(' ');

                var product = stock[1];
                var quantity = int.Parse(stock[2]);

                if (!products.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (products[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        products[product] -= quantity;

                        if (products[product] < 0)
                        {
                            products[product] = 0;
                        }
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var productQuantityPair in products)
            {
                var product = productQuantityPair.Key;
                var quantity = productQuantityPair.Value;

                if (quantity > 0)
                {
                    Console.WriteLine($"{product} -> {quantity}");
                }
            }
        }
    }
}
