using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SerializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<char, List<int>>();

            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                var @char = input[i];

                if (!result.ContainsKey(@char))
                {
                    result[@char] = new List<int>();
                }
                result[@char].Add(i);
            }

            foreach (var pair in result)
            {
                var @char = pair.Key;
                var indexes = pair.Value;

                Console.WriteLine($"{@char}:{string.Join("/", indexes)}");
            }
        }
    }
}
