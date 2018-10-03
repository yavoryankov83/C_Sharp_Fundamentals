using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DistanceofTheStars
{
    class DistanceofTheStars
    {
        static void Main(string[] args)
        {
            var dist1 = 4.22M * 9450000000000;
            var dist2 = 26000M * 9450000000000;
            var dist3 = 100000M * 9450000000000;
            var dist4 = 46500000000M * 9450000000000;

            Console.WriteLine("{0:e2}", dist1);
            Console.WriteLine("{0:e2}", dist2);
            Console.WriteLine("{0:e2}", dist3);
            Console.WriteLine("{0:e2}", dist4);
        }
    }
}
