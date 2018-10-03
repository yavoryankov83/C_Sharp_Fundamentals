using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SignofIntegerNumber
{
    class SignofIntegerNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            PrintSign(n);
        }

        private static void PrintSign(int n)
        {
            var sign = string.Empty;

            if (n == 0)
            {
                sign = "zero";
            }
            else if (n < 0)
            {
                sign = "negative";
            }
            else
            {
                sign = "positive";
            }
            Console.WriteLine($"The number {n} is {sign}.");
        }
    }
}
