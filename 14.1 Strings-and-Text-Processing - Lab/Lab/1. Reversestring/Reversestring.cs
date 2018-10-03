using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reversestring
{
    class Reversestring
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            //first way
            //var result = string.Empty;

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    result += str[i];
            //}

            //Console.WriteLine(result);

            //second way
            var result = str.Reverse().ToArray();

            Console.WriteLine(result);
        }
    }
}
