using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToBase
{
    class IntegerToBase
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var baseOfNumber = int.Parse(Console.ReadLine());

            var newNumber = NumToBase(number, baseOfNumber);
            Console.WriteLine(newNumber);
        }

        private static string NumToBase(int number, int baseOfNumber)
        {
            var newNumber = string.Empty;

            while (number > 0)
            {
                var reminder = number % baseOfNumber;
                number /= baseOfNumber;
                newNumber = reminder + newNumber;
            }
            
            return newNumber;
        }
    }
}
