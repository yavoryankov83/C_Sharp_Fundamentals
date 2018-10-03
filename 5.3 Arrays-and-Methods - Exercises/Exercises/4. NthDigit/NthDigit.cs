using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());

            var result = FindDigit(num, index);
            Console.WriteLine(result);
        }

        private static long FindDigit(long num, int index)
        {
            var currentDigit = 0L;
            var currentIndex = 1;

            while (num > 0)
            {
                currentDigit = num % 10;

                if (index == currentIndex)
                {
                    currentDigit = num % 10;
                    break;
                }
                else
                {
                    num /= 10;
                }
                currentIndex++;
            }
            return currentDigit;
        }
    }
}
