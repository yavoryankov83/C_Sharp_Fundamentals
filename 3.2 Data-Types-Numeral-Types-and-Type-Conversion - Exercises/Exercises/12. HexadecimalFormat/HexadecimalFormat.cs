using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.HexadecimalFormat
{
    class HexadecimalFormat
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            var numDec = Convert.ToInt32(number, 16);

            Console.WriteLine(numDec);
        }
    }
}
