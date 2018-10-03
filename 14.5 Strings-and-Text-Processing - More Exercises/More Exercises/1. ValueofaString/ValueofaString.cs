using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ValueofaString
{
    class ValueofaString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var letterCase = Console.ReadLine();

            var sumOfUppercase = 0;
            var sumOfLowercase = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    sumOfUppercase += (int)input[i];
                }
                else if (char.IsLower(input[i]))
                {
                    sumOfLowercase += (int)input[i];
                }
            }

            if (letterCase == "UPPERCASE")
            {
                Console.WriteLine($"The total sum is: {sumOfUppercase}");
            }
            else
            {
                Console.WriteLine($"The total sum is: {sumOfLowercase}");
            }
        }
    }
}
