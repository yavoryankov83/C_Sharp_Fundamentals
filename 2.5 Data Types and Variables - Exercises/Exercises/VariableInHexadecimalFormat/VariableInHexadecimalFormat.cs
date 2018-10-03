using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            var numInHex = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(numInHex, 16));
        }
    }
}
