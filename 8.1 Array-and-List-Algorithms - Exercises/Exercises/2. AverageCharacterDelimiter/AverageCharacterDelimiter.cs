using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var sum = 0;
            var lenght = 0;

            for (int i = 0; i < input.Count; i++)
            {
                var currentStr = input[i];
                lenght += currentStr.Length;

                for (int j = 0; j < currentStr.Length; j++)
                {
                    sum += (int)currentStr[j];                    
                }
            }

            var final = sum / lenght;

            var delimer = char.ToUpper((char)final);

            for (int i = 0; i < input.Count; i++)
            {
                if (i < input.Count - 1)
                {
                    Console.Write(input[i] + delimer);
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
