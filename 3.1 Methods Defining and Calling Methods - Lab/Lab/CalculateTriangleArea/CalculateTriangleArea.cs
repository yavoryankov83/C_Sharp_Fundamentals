using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var face = CalculateArea(side, height);
            Console.WriteLine(face);
        }

        static double CalculateArea(double side, double height)
        {
            var area = (side * height) / 2;
            return area;
        }
    }
}
