using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            Point point1 = Point.ParsedPoint(Console.ReadLine());
            Point point2 = Point.ParsedPoint(Console.ReadLine());

            var distance = CalcDistance(point1, point2);

            Console.WriteLine($"{distance:F3}");
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var pointByX = Math.Pow((firstPoint.X - secondPoint.X), 2);
            var pointByY = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            return Math.Sqrt(pointByX + pointByY);
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int firstX, int firstY)
        {
            X = firstX;
            Y = firstY;
        }

        public static Point ParsedPoint(string coordinates)
        {
            var input = coordinates.Split(' ');

            return new Point(int.Parse(input[0]), int.Parse(input[1]));
        }
    }
}
