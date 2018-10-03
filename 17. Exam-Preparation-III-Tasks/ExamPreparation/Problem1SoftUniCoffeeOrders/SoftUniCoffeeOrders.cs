using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            var data = new List<string>();
            var totalPrise = 0.0M;

            var ordersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < ordersCount; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    data.Add(Console.ReadLine());
                }

                var price = decimal.Parse(data[0]);
                var date = DateTime
                    .ParseExact(data[1], "d/M/yyyy", CultureInfo.InvariantCulture);
                var count = long.Parse(data[2]);
                    
                var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                var orderPrice = daysInMonth * count * price;
                totalPrise += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
                data.Clear();
            }
            Console.WriteLine($"Total: ${totalPrise:F2}");
        }
    }
}
