using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    class Count
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var count = 0;

            while (true)
            {
                int number;
                var line = int.TryParse(input, out number);

                if (line)
                {
                    count++;
                }
                else
                {
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(count);
        }
    }
}
