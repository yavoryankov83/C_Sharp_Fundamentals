using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = num * i;
                Console.WriteLine($"{num} X {i} = {sum}");
            }
        }
    }
}
