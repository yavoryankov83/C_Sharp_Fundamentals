using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountofGivenElementinArray
{
    class CountofGivenElementinArray
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var num = int.Parse(Console.ReadLine());

            var count = list
                .Count(n => n == num);

            Console.WriteLine(count);
        }
    }
}
