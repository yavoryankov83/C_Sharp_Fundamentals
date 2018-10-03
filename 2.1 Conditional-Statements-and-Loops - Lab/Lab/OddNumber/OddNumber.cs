using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            while (true)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }

                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
