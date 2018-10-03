using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger num = 1;

            for (int i = 1; i <= n; i++)
            {
                num *= i;
            }

            Console.WriteLine(num);
        }
    }
}
