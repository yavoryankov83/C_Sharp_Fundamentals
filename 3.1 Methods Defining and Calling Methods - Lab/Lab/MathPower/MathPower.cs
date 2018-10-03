using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var pow = int.Parse(Console.ReadLine());

            var result = RaisePower(number, pow);
            Console.WriteLine(result);
        }

        static double RaisePower(double number, int pow)
        {
            var result = 1D;

            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
