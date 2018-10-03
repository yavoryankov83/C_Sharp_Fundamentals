using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine(list.Contains(num) ? "yes" : "no");
        }
    }
}
