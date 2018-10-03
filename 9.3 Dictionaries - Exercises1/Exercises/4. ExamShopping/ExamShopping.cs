using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "exam time")
            {
                if (input == "shopping time")
                {
                    input = Console.ReadLine();

                    if (input == "exam time")
                    {
                        break;
                    }
                }

                var tokens = input.Split(' ');

                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (input.Contains("stock"))
                {
                    if (!result.ContainsKey(product))
                    {
                        result.Add(product, quantity);
                    }
                    else
                    {
                        result[product] += quantity;
                    }
                }

                else if (input.Contains("buy"))
                {
                    if (!result.ContainsKey(product))
                    {
                        Console.WriteLine($"{product} doesn't exist");
                    }
                    else if (result.ContainsKey(product) && result[product] <= 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else if (quantity > result[product])
                    {
                        result[product] = 0;
                    }
                    else
                    {
                        result[product] -= quantity;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in result)
            {
                if (pair.Value > 0)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
