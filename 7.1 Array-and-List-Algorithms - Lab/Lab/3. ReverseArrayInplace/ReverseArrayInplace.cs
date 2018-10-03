using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ReverseArrayInplace
{
    class ReverseArrayInplace
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            list.Reverse();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
