using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MirrorImage
{
    class MirrorImage
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var indexes = Console.ReadLine();

            var result = new List<string>();

            while (indexes != "Print")
            {
                var index = int.Parse(indexes);

                var result1 = input
                    .Take(index)
                    .Reverse()
                    .ToList();

                result1.Add(input[index]);

                var result2 = input
                    .Skip(index + 1)
                    .Reverse()
                    .ToList();

                result = result1
                    .Concat(result2)
                    .ToList();

                input.Clear();

                for (int i = 0; i < result.Count; i++)
                {
                    input.Add(result[i]);
                }

                indexes = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
