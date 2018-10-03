using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("{0:F12}", area);
        }
    }
}
