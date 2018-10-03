using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var input = Console.ReadLine();

            while (input != "colapse")
            {
                result.Add(input);
                input = Console.ReadLine();
                result.Add(input);

                Console.WriteLine(string.Join(" ", result));

                var first = result[0];
                var second = result[1];

                while (second.Length > 0)
                {
                    if (first.Contains(second))
                    {
                        first.Remove(first.IndexOf(second, second.Length));
                    }

                    second = second.Remove(0, 1);
                    result[1].Remove(result[1].Length - 1, 1);
                }
                Console.WriteLine(result[0]);
                result.Clear();

                input = Console.ReadLine();
            }
        }
    }
}
