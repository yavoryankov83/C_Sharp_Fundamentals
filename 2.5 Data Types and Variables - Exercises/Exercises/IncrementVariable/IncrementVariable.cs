using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            byte variable = 0;
            var count = 0;

            for (int i = 0; i < n; i++)
            {
                variable++;

                if (variable == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(variable);
            if (count > 0)
            {
                Console.WriteLine($"Overflowed {count} times");
            }
        }
    }
}
