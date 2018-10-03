using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOccurrencesLargerNumbersArray
{
    class CountOccurrencesLargerNumbersArray
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var num = double.Parse(Console.ReadLine());

            var result = list
                .Count(n => n > num);

            Console.WriteLine(result);
        }
    }
}
