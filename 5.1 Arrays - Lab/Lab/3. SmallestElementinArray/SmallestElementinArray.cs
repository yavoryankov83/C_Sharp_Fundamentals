using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SmallestElementinArray
{
    class SmallestElementinArray
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var min = nums
                .Min();

            Console.WriteLine(min);
        }
    }
}
