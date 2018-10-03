using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            var result = new List<Sale>();

            var n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                var current = Sale.ParcedSale(Console.ReadLine());
                result.Add(current);
            }

            var towns = result
                .Select(s => s.Town)
                .Distinct()
                .OrderBy(t => t);

            foreach (var town in towns)
            {
                var currentSum = result
                    .Where(s => s.Town == town)
                    .Select(s => s.Price * s.Quantity)
                    .Sum();

                Console.WriteLine($"{town} -> {currentSum:F2}");
            }
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Sale(string town, string product, double price, double quantity)
        {
            Town = town;
            Product = product;
            Price = price;
            Quantity = quantity;
        }
        public static Sale ParcedSale(string input)
        {
            var tokens = input.Split(' ');
            var town = tokens[0];
            var product = tokens[1];
            var price = double.Parse(tokens[2]);
            var quantity = double.Parse(tokens[3]);

            return new Sale(town, product, price, quantity);
        }
    }
}
