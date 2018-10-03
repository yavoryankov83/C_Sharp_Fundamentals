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
            var num = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = num; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
