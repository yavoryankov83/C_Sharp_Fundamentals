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
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = Distance(firstPoint, secondPoint);

            Console.WriteLine("{0:F3}", result);

            //read points without a method

            //var firstPointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var secondPointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var firstPoint = new Point
            //{
            //    X = firstPointParts[0],
            //    Y = firstPointParts[1]
            //};

            //var secondPoint = new Point
            //{
            //    X = secondPointParts[0],
            //    Y = secondPointParts[1]
            //};

        }

        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow((first.X - second.X), 2);
            var squareY = Math.Pow((first.Y - second.Y), 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }

        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }
    }
}
