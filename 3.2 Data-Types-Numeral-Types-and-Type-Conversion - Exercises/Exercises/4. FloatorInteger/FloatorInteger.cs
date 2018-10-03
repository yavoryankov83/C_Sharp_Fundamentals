using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FloatorInteger
{
    class FloatorInteger
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(num));
        }
    }
}
