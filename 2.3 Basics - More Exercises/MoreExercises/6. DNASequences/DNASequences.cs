using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DNASequences
{
    class DNASequences
    {
        static void Main(string[] args)
        {
            var matchSum = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;

            var dnaList = new List<char>()
            {
                'O', 'A', 'C', 'G', 'T', 'X',
            };

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        count++;

                        sum = i + j + k;

                        if (sum >= matchSum)
                        {
                            Console.Write($"{dnaList[0]}{dnaList[i]}{dnaList[j]}{dnaList[k]}{dnaList[0]} ");
                        }
                        else
                        {
                            Console.Write($"{dnaList[5]}{dnaList[i]}{dnaList[j]}{dnaList[k]}{dnaList[5]} ");
                        }

                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
