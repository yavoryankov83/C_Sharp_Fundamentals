using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMethod
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            var min = GetMin(num1, num2, num3);
            Console.WriteLine(min);
        }

        private static int GetMin(int num1, int num2)
        {
            var min = num1;

            if (num2 <= num1)
            {
                min = num2;
            }

            return min;
        }

        private static int GetMin(int num1, int num2, int num3)
        {
            var min = num3;

            if (GetMin(num1, num2) <= num3)
            {
                min = GetMin(num1, num2);
            }

            return min;
        }
    }
}
