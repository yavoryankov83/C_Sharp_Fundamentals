using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int number;
            var num = int.TryParse(input, out number);

            Console.WriteLine(num == true ? "It is a number." : "Invalid input!");
        }
    }
}
