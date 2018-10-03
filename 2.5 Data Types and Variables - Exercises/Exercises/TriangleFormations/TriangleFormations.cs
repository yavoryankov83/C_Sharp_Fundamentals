using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFormations
{
    class TriangleFormations
    {
        static void Main(string[] args)
        {
            var sidaA = int.Parse(Console.ReadLine());
            var sidaB = int.Parse(Console.ReadLine());
            var sidaC = int.Parse(Console.ReadLine());

            var isValid = sidaA + sidaB > sidaC && sidaA + sidaC > sidaB && sidaB + sidaC > sidaA;

            Console.WriteLine(isValid ? "Triangle is valid." : "Invalid Triangle.");

            if (isValid == true && (sidaA * sidaA + sidaB * sidaB == sidaC * sidaC))
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (isValid == true && (sidaA * sidaA + sidaC * sidaC == sidaB * sidaB))
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else if (isValid == true && (sidaB * sidaB + sidaC * sidaC == sidaA * sidaA))
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
        }
    }
}
