using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var result = SumEvenDigits(number) * SumOddDigits(number);
            Console.WriteLine(result);

        }

        private static int SumOddDigits(int num)
        {
            var sumOddDigits = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 != 0)
                {
                    sumOddDigits += digit;
                }
                num /= 10;
            }
            return sumOddDigits;
        }

        private static int SumEvenDigits(int num)
        {
            var sumEvenDigits = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 == 0)
                {
                    sumEvenDigits += digit;
                }
                num /= 10;
            }
            return sumEvenDigits;
        }
    }
}
