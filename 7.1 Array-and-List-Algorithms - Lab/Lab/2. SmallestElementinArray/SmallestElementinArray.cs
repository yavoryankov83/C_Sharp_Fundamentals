using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SmallestElementinArray
{
    class SmallestElementinArray
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(list.Min());
        }
    }
}
