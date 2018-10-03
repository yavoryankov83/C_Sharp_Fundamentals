using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCIIString
{
    class ASCIIString
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                word += (char)num;
            }
            Console.WriteLine(word);
        }
    }
}
