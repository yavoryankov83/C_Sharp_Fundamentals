using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SalesReport
{
    class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }

        public static Sale Parse(string input)
        {
            var line = input
                .Split(' ');

            return new Sale
            {
                Town = line[0],
                Product = line[1],
                Price = double.Parse(line[2]),
                Quantity = double.Parse(line[3])
            };
        }
    }
}
