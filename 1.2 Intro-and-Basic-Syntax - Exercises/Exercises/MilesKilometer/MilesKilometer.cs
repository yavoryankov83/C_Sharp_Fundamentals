using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesKilometer
{
    class MilesKilometer
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());

            var kilometers = miles * 1.60934;

            Console.WriteLine("{0:F2}", kilometers);
        }
    }
}
