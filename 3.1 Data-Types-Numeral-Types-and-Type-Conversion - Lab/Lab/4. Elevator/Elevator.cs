using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            var peopleCount = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());

            var times = Math.Ceiling(peopleCount / (double)capacity);

            Console.WriteLine(times);
        }
    }
}
