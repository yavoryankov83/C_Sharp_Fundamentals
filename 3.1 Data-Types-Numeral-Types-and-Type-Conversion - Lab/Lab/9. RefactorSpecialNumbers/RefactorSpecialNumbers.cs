using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                var sum = 0;
                var num = i;

                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                var isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
