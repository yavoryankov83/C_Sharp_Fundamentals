    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                var sum = 0;
                var num = i;

                while (num > 0)
                {
                    var digit = num % 10;
                    sum += digit;
                    num /= 10;
                }
                var isSpesial = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {isSpesial}");
            }
            
        }
    }
}
