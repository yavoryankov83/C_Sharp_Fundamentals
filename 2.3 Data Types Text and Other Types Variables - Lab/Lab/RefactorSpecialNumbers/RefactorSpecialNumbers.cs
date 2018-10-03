using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            var maxNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= maxNumber; i++)
            {
                var currentNumber = i;
                var sum = 0;

                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                var isSpecial = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
