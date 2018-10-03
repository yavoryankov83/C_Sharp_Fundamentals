using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var repeated = RepeatString(str, count);
            Console.WriteLine(repeated);
        }

        private static string RepeatString(string str, int count)
        {
            var repeated = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeated += str;
            }

            return repeated;
        }
    }
}
