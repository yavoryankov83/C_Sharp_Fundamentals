using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            DrawSquare(n);
        }

        private static void DrawSquare(int n)
        {
            DrawFirstAndLastRow(n);
            DrawMiddlePart(n);
            DrawFirstAndLastRow(n);
        }

        private static void DrawMiddlePart(int n)
        {
            var body = "-";
            var symbol = @"\/";
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(body);
                for (int j = 0; j < n -1; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(body);
            }
        }

        private static void DrawFirstAndLastRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
