using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.DebuggingExerciseMiningCoins
{
    class DebuggingExerciseMiningCoins
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var decrypted = string.Empty;
            var totalValue = 0F;

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                var digit1 = number / 100;
                var digit2 = (number / 10) % 10;
                var digit3 = number % 10;

                int ASCIIcode = 0;

                if (i % 2 == 0)
                {
                    ASCIIcode = ((digit1 * 10) + digit3) + digit2;
                }
                else
                {
                    ASCIIcode = ((digit1 * 10) + digit3) - digit2;
                }

                if ((ASCIIcode >= 65 && ASCIIcode <= 90) || (ASCIIcode >= 97 && ASCIIcode <= 122))
                {
                    decrypted += (char)ASCIIcode;
                }

                var tempSum = (digit1 + digit2 + digit3) / (float)n;

                totalValue += tempSum;
            }

            Console.WriteLine("Message: {0}", decrypted);

            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}
