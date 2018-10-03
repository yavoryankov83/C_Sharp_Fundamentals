using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.StringEncryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var letter = char.Parse(Console.ReadLine());

                var code = (int)letter;

                var lastDigit = code % 10;
                var firstDigit = 0;

                var num = code;

                while (num >= 10)
                {
                    num /= 10;
                    firstDigit = num;
                }

                var firstLastDigit = firstDigit + "" + lastDigit;
                var secondStr = (char)(code + lastDigit);
                var thirdStr = (char)(code - firstDigit);

                result += secondStr + "" + firstLastDigit + "" + thirdStr + "";
            }
            Console.WriteLine(result);
        }
    }
}
