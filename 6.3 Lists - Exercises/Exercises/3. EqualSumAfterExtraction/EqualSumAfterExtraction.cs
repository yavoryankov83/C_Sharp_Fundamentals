using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            var lineA = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var lineB = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var sumListA = lineA.Sum();

            for (int i = 0; i < lineA.Count; i++)
            {
                if (lineB.Contains(lineA[i]))
                {
                    lineB.RemoveAll(x => x == lineA[i]);
                }
            }

            var sumListB = lineB.Sum();

            if (sumListA == sumListB)
            {
                Console.WriteLine($"Yes. Sum: {sumListA}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumListA - sumListB)}");
            }
        }
    }
}
