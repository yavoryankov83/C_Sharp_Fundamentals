using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MinMethod
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var result = new List<int>();
            result.Add(a);
            result.Add(b);
            result.Add(c);

            var min = result.Min();

            Console.WriteLine(min);
        }
    }
}
