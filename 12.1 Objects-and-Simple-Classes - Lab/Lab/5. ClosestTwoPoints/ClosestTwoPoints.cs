using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var list = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point currentPoint = Point.ParsedPoint(Console.ReadLine());

                list.Add(currentPoint);
            }

            double minDistance = double.MaxValue;
            Point[] bestPoints = new Point[2];


            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    double distance = CalcDistance(list[i], list[j]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        bestPoints[0] = list[i];
                        bestPoints[1] = list[j];
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"{bestPoints[0]}");
            Console.WriteLine($"{bestPoints[1]}");
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
        public override string ToString()
        {
            return string.Format($"({X}, {Y})");
        }
    }
}
