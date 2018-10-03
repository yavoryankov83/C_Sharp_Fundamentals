using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var result = new List<char>();

            for (int i = 0; i < input.Count; i++)
            {
                var current = input[i].Split('.');

                var firstPart = int.Parse(current[0]);
                var secondPart = int.Parse(current[1]);

                if (firstPart != 0)
                {
                    result.Insert(i, (char)firstPart);
                }

                if (secondPart != 0 )
                {
                    result.Insert(result.Count - i - 1, (char)secondPart);
                }
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}
