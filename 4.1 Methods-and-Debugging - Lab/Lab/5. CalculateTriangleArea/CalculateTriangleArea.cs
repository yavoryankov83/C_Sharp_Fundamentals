using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = CalculateArea(side, height);
            Console.WriteLine(area);
        }

        private static double CalculateArea(double side, double height)
        {
            var area = side * height / 2.0;
            return area;
        }
    }
}
