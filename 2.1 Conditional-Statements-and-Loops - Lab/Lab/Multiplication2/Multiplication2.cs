using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication2
{
    class Multiplication2
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var multiplayer = int.Parse(Console.ReadLine());

            var sum = 0;

            if (multiplayer > 10)
            {
                Console.WriteLine($"{num} X {multiplayer} = {num * multiplayer}");
            }
            else
            {
                for (int i = multiplayer; i <= 10; i++)
                {
                    sum = num * i;
                    Console.WriteLine($"{num} X {i} = {sum}");
                }
            }
        }
    }
}
