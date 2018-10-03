using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Stateless
{
    class Stateless
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var input = Console.ReadLine();

            while (input != "collapse")
            {
                result.Add(input);
                input = Console.ReadLine();
                result.Add(input);

                var first = result[0];
                var second = result[1];

                while (second.Length > 0)
                {
                    if (first.Contains(second))
                    {
                        first = first.Replace(second, string.Empty);
                    }
                    else
                    {
                        second = second.Remove(0, 1);

                        if (second.Length > 0)
                        {
                            second = second.Remove((second.Length - 1), 1);
                        }
                    }
                }
                if (first.Length > 0)
                {
                    Console.WriteLine(first.Trim());
                }
                else
                {
                    Console.WriteLine("(void)");
                }
                
                result.Clear();

                input = Console.ReadLine();
            }
        }
    }
}

