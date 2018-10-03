using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var pow = int.Parse(Console.ReadLine());

            CalculatePow(num, pow);
        }

        private static void CalculatePow(double num, int pow)
        {
            var result = 1.0;

            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            Console.WriteLine(result);
        }
    }
}
