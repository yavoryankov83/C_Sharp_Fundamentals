using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var fisrtRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            var result = fisrtRectangle
                .IsInside(secondRectangle);

            var printResult = result
                ? "Inside"
                : "Not inside";

            Console.WriteLine(printResult);
        }

        private static Rectangle ReadRectangle()
        {
            var rectangleParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            return new Rectangle
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
        }
    }
}
