using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            var person = int.Parse(Console.ReadLine());
            var courses = (double)person / (4 + 8 + 12);

            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
