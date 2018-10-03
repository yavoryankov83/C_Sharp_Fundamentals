using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOddNumbers
{
    class SumOddNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;
            var count = 0;
            var sum = 0;

            while (count < n)
            {
                sum += num;
                Console.WriteLine(num);
                num += 2;
                count++;
            }
            Console.WriteLine($"Sum: {sum}");
            
        }
    }
}
