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
            var n = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var saleAsString = Console.ReadLine();
                var sale = Sale.Parse(saleAsString);

                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }

                result[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var kpv in result)
            {
                Console.WriteLine($"{kpv.Key} -> {kpv.Value:F2}");
            }
        }
    }
}
