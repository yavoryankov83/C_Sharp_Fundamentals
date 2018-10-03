using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.TriangleFormations
{
    class TriangleFormations
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var isValid = a + b > c && a + c > b && b + c > a;
            var isRight = a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a;

            if (!isValid)
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }
            else
            {
                Console.WriteLine("Triangle is valid.");

                if (!isRight)
                {
                    Console.WriteLine("Triangle has no right angles");
                }
                else
                {
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine("Triangle has a right angle between sides a and b");
                    }
                    else if (c * c + b * b == a * a)
                    {
                        Console.WriteLine("Triangle has a right angle between sides b and c");
                    }
                    else
                    {
                        Console.WriteLine("Triangle has a right angle between sides a and c");
                    }
                }
            }
        }
    }
}
