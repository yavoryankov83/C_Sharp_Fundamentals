using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main(string[] args)
        {
            var terabytes = decimal.Parse(Console.ReadLine());

            decimal bits = terabytes * 1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine(Math.Round(bits));
        }
    }
}
