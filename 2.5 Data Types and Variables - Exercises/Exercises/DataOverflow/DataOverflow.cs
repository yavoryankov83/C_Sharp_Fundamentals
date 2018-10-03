using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOverflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            var num1 = ulong.Parse(Console.ReadLine());
            var num2 = ulong.Parse(Console.ReadLine());

            var bigger = num1;
            var type1 = "";
            var type2 = "";
            var max1 = 0UL;
            var max2 = 0UL;

            if (num2 > num1)
            {
                bigger = num2;
            }

            if (byte.MinValue <= num1 && num1 <= byte.MaxValue)
            {
                type1 = "byte";
                max1 = byte.MaxValue;
            }
            else if (ushort.MinValue <= num1 && num1 <= ushort.MaxValue)
            {
                type1 = "ushort";
                max1 = ushort.MaxValue;
            }
            else if (uint.MinValue <= num1 && num1 <= uint.MaxValue)
            {
                type1 = "uint";
                max1 = uint.MaxValue;
            }
            else if (ulong.MinValue <= num1 && num1 <= ulong.MaxValue)
            {
                type1 = "ulong";
                max1 = ulong.MaxValue;
            }

            if (byte.MinValue <= num2 && num2 <= byte.MaxValue)
            {
                type2 = "byte";
                max2 = byte.MaxValue;
            }
            else if (ushort.MinValue <= num2 && num2 <= ushort.MaxValue)
            {
                type2 = "ushort";
                max2 = ushort.MaxValue;
            }
            else if (uint.MinValue <= num2 && num2 <= uint.MaxValue)
            {
                type2 = "uint";
                max2 = uint.MaxValue;
            }
            else if (ulong.MinValue <= num2 && num2 <= ulong.MaxValue)
            {
                type2 = "ulong";
                max2 = ulong.MaxValue;
            }

            if (bigger == num1)
            {
                Console.WriteLine($"bigger type: {type1}");
                Console.WriteLine($"smaller type: {type2}");
                Console.WriteLine($"{num1} can overflow {type2} {Math.Round(num1 / (double)max2)} times");
            }
            else
            {
                Console.WriteLine($"bigger type: {type2}");
                Console.WriteLine($"smaller type: {type1}");
                Console.WriteLine($"{num2} can overflow {type1} {Math.Round(num2 / (double)max1)} times");
            }
        }
    }
}
