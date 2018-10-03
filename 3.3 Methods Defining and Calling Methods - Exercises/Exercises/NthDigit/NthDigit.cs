using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());

            var digit = FindDigit(number, index);
            Console.WriteLine(digit);
        }

        private static int FindDigit(int number, int index)
        {
            var count = 1;
            var digit = 0;

            while (count <= index)
            {
                digit = number % 10;
                number /= 10;
                count++;
            }

            return digit;
        }
    }
}
