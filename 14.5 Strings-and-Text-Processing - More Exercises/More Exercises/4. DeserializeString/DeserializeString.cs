using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DeserializeString
{
    class DeserializeString
    {
        static void Main(string[] args)
        {
            var indexPositions = new SortedDictionary<int, char>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(':');

                var @char = tokens[0][0];
                var indexes = tokens[1]
                    .Split('/')
                    .Select(int.Parse)
                    .ToArray();

                foreach (var index in indexes)
                {
                    indexPositions[index] = @char;
                }

            input = Console.ReadLine();
            }
            Console.WriteLine(indexPositions.Values.ToArray());
        }
    }
}
