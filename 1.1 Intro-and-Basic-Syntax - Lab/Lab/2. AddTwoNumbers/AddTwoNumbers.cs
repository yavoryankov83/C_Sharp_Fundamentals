using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AddTwoNumbers
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            var numA = int.Parse(Console.ReadLine());
            var numB = int.Parse(Console.ReadLine());

            var sum = numA + numB;

            Console.WriteLine($"{numA} + {numB} = {sum}");
        }
    }
}
