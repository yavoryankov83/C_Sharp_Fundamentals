using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _7.FromTerabytestoBits
{
    class FromTerabytestoBits
    {
        static void Main(string[] args)
        {
            var terabytes = decimal.Parse(Console.ReadLine());
            decimal bits = terabytes * 1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine("{0:F0}", bits);
        }
    }
}
