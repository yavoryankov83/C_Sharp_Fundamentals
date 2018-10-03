using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ExactSumofRealNumbers
{
    class ExactSumofRealNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0M;

            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
