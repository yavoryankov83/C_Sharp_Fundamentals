using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DrawFilledSquare
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
            DrawLine1(n);
            DrawLine2(n);
            DrawLine1(n);
        }

        private static void DrawLine2(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        private static void DrawLine1(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
