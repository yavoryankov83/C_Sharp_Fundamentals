using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            var width = decimal.Parse(Console.ReadLine());
            var height = decimal.Parse(Console.ReadLine());

            var megapixels = Math.Round((width * height) / 1000000, 1);

            Console.WriteLine($"{width}x{height} => {megapixels}MP");
        }
    }
}
