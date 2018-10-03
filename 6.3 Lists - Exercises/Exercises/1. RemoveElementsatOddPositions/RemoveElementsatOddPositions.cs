using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.RemoveElementsatOddPositions
{
    class RemoveElementsatOddPositions
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var line = Console.ReadLine().Split(' ').ToList();

            for (int i = 1; i < line.Count; i+=2)
            {
                result.Add(line[i]);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
