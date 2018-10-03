using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MultiplyEvensbyOdds
{
    class MultiplyEvensbyOdds
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var result = GetMultipleOfEvenOddDigits(num);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenOddDigits(int num)
        {
            var evenSum = GetSumOfEvenDigits(num);
            var oddSum = GetSumOfOddDigits(num);
            return evenSum * oddSum;
        }

        private static int GetSumOfOddDigits(int num)
        {
            var sum = 0;

            while (Math.Abs(num) > 0)
            {
                var lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }

            return sum;
        }

        private static int GetSumOfEvenDigits(int num)
        {
            var sum = 0;

            while (Math.Abs(num) > 0)
            {
                var lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }

            return sum;
        }
    }
}
