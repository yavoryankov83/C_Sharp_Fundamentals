using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
