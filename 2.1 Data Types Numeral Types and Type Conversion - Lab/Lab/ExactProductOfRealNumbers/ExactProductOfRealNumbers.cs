using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactProductOfRealNumbers
{
    class ExactProductOfRealNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var product = 1M;
            for (int i = 0; i < n; i++)
            {
                product *= decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(product);
        }
    }
}
