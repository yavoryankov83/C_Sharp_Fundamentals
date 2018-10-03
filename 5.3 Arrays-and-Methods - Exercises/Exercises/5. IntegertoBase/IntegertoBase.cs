using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.IntegertoBase
{
    class IntegertoBase
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var numBase = int.Parse(Console.ReadLine());

            var result = string.Empty;

            while (num > 0)
            {
                var reminder = num % numBase;
                result = reminder + result;
                num /= numBase;
            }
            Console.WriteLine(result);
        }
    }
}
