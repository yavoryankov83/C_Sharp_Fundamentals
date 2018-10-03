using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Boxes
{
    class Boxes
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var newBox = new Box();
                newBox = Box.ReadBox(input);
                boxes.Add(newBox);

                input = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter((int)box.Width, (int)box.Height)}");
                Console.WriteLine($"Area: {Box.CalculateArea((int)box.Width, (int)box.Height)}");
            }
        }
    }
    class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }

        public static Box ReadBox(string input)
        {
            var tokens = input
                    .Split(new string[] { " | " }, StringSplitOptions
                    .RemoveEmptyEntries);

            var UpperLeftCordinates = tokens[0].Split(':');
            var UpperRightCordinates = tokens[1].Split(':');
            var BottomLeftCordinates = tokens[2].Split(':');
            var BottomRightCordinates = tokens[3].Split(':');

            return new Box
            {
                UpperLeft = new Point
                {
                    X = int.Parse(UpperLeftCordinates[0]),
                    Y = int.Parse(UpperLeftCordinates[1])
                },

                UpperRight = new Point
                {
                    X = int.Parse(UpperRightCordinates[0]),
                    Y = int.Parse(UpperRightCordinates[1])
                },

                BottomLeft = new Point
                {
                    X = int.Parse(BottomLeftCordinates[0]),
                    Y = int.Parse(BottomLeftCordinates[1])
                },

                BottomRight = new Point
                {
                    X = int.Parse(BottomRightCordinates[0]),
                    Y = int.Parse(BottomRightCordinates[0])
                }
            };
        }
        public double Width
        {
            get {
                return Point.CalcDistance(UpperLeft, UpperRight);
                }
        }

        public double Height
        {
            get {
                return Point.CalcDistance(UpperLeft, BottomLeft);
                }
        }
        public static int CalculatePerimeter(int width, int height)
        {
            int perimeter = 2 * width + 2 * height;
            return perimeter;
        }

        public static int CalculateArea(int width, int height)
        {
            int area = width * height;
            return area;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var pointByX = Math.Pow((firstPoint.X - secondPoint.X), 2);
            var pointByY = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            return Math.Sqrt(pointByX + pointByY);
        }
    }
}
