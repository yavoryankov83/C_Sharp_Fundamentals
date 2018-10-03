using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeter
{
    class CirclePerimeter
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());

            var perimeter = Math.PI * radius * 2;

            Console.WriteLine("{0:f12}", perimeter);
        }
    }
}
