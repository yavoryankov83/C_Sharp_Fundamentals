using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MostValuedCustomer
{
    class MostValuedCustomer
    {
        static void Main(string[] args)
        {
            var productsForSale = new Dictionary<string, double>();

            var result = new Dictionary<string, Dictionary<string, double>>();

            var input = Console.ReadLine();

            while (input != "Shop is open")
            {
                var tokens = input
                    .Split(' ');

                var productName = tokens[0];
                var productPrice = double.Parse(tokens[1]);

                if (!productsForSale.ContainsKey(productName))
                {
                    productsForSale.Add(productName, 0);
                }

                productsForSale[productName] = productPrice;

                input = Console.ReadLine();
            }
            
            var input2 = Console.ReadLine();

            while (input2 != "Print")
            {
                var tokens2 = input2
               .Split(new string[] { ": " }, StringSplitOptions
                   .RemoveEmptyEntries).ToList();

                if (tokens2[0] == "Discount")
                {
                    var productsForSaleOrdered = productsForSale
                       .OrderByDescending(a => a.Value)
                       .ToDictionary(a => a.Key, a => a.Value);

                    var values = productsForSaleOrdered.Values.ToList();

                    for (int i = 0; i < 3; i++)
                    {
                        values[i] = values[i] - values[i] * 0.1;
                        values.RemoveAt(i);
                        values.Insert(i, values[i]);
                    }
                }

                else
                {
                    var customerName = tokens2[0];
                    var boughtProduct = tokens2[1];

                    var currentProduct = boughtProduct
                        .Split(new string[] { ", " }, StringSplitOptions
                        .RemoveEmptyEntries);

                    if (!result.ContainsKey(customerName))
                    {
                        result.Add(customerName, new Dictionary<string, double>());
                    }

                    foreach (var product in currentProduct)
                    {
                        if (!result[customerName].ContainsKey(product))
                        {
                            result[customerName][product] = productsForSale[product];
                        }
                        else
                        {
                            result[customerName][product] += productsForSale[product];

                        }
                    }
                }

                input2 = Console.ReadLine();
            }

            foreach (var pair in result.OrderByDescending(x => x.Value.Values.Sum()).Take(1))
            {
                var customerName = pair.Key;
                var productAndPrice = pair.Value;

                Console.WriteLine($"Biggest spender: {customerName}");
                Console.WriteLine("^Products bought:");

                var sum = 0.0;

                foreach (var pair2 in productAndPrice)
                {
                    var product = pair2.Key;
                    var price = pair2.Value;

                    sum += price;

                    Console.WriteLine($"^^^{product}: {price:F2}");
                }
                Console.WriteLine($"Total: {sum:F2}");
            }
        }
    }
}
