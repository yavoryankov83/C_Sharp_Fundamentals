using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            var maxNumber = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= maxNumber; i++)
            {
                var currentNumber = i;
                var sum = 0;

                foreach (var symbol in currentNumber.ToString())
                {
                    var digit = symbol - '0';
                    sum += digit;
                }
                var result = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{currentNumber} -> {result}");
            }
        }
    }
}
