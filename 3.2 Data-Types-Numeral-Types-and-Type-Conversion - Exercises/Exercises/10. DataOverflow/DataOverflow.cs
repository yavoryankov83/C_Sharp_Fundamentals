using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DataOverflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            var a = ulong.Parse(Console.ReadLine());
            var b = ulong.Parse(Console.ReadLine());

            var typeBigger = string.Empty;
            var typeSmaller = string.Empty;

            var bigger = Math.Max(a, b);
            var smaller = Math.Min(a, b);
            ulong smallValue = 0;

            if (bigger <= byte.MaxValue && bigger >= byte.MinValue)
            {
                typeBigger = "byte";
            }
            else if (bigger <= ushort.MaxValue && bigger >= ushort.MinValue)
            {
                typeBigger = "ushort";
            }
            else if (bigger <= uint.MaxValue && bigger >= uint.MinValue)
            {
                typeBigger = "uint";
            }
            else if (bigger <= ulong.MaxValue && bigger >= ulong.MinValue)
            {
                typeBigger = "ulong";
            }

            if (smaller <= byte.MaxValue && smaller >= byte.MinValue)
            {
                typeSmaller = "byte";
                smallValue = byte.MaxValue;
            }
            else if (smaller <= ushort.MaxValue && smaller >= ushort.MinValue)
            {
                typeSmaller = "ushort";
                smallValue = ushort.MaxValue;
            }
            else if (smaller <= uint.MaxValue && smaller >= uint.MinValue)
            {
                typeSmaller = "uint";
                smallValue = uint.MaxValue;
            }
            else if (smaller <= ulong.MaxValue && smaller >= ulong.MinValue)
            {
                typeSmaller = "ulong";
                smallValue = ulong.MaxValue;
            }

            var times = Math.Round((double)bigger / smallValue);

            Console.WriteLine($"bigger type: {typeBigger}");
            Console.WriteLine($"smaller type: {typeSmaller}");
            Console.WriteLine($"{bigger} can overflow {typeSmaller} {times} times");
        }
    }
}
