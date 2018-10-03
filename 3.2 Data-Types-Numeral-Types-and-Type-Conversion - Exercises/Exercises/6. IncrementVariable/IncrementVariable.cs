using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var count = 0;
            byte num = 0;

            for (int i = 0; i < n; i++)
            {
                num++;

                if (num == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(num);

            if (count > 0)
            {
                Console.WriteLine($"Overflowed {count} times");
            }
        }
    }
}
