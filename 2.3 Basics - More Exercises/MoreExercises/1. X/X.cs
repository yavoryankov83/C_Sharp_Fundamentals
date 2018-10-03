    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _1.X
    {
        class X
        {
            static void Main(string[] args)
            {
                var height = int.Parse(Console.ReadLine());

                for (int i = 0; i < height / 2; i++)
                {
                    Console.WriteLine(new string(' ', 0 + i) + 'x' + new string(' ', height - 2 - (2 * i)) + 'x');

                }
                Console.WriteLine(new string(' ', 0 + (height - 1) /2) + 'x');

                for (int i = 0; i < height / 2; i++)
                {
                    Console.WriteLine(new string(' ', (height - 3) / 2 - i) +
                        'x' +
                        new string(' ', 2 * i + 1) +
                        'x' +
                        new string(' ', (height - 3) / 2 - i));
                }
            }
        }
    }
