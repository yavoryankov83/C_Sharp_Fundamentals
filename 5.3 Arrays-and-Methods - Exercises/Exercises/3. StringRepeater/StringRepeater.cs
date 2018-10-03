using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.StringRepeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var result = RepeatString(str, count);
            Console.WriteLine(result);
        }

        private static string RepeatString(string str, int count)
        {
            var result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
