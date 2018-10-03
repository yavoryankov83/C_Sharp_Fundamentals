using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    class Interval
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            var smallest = FindSmallest(startNum, endNum);

            for (int i = smallest; i <= Math.Max(startNum, endNum); i++)
            {
                Console.WriteLine(i);
            }
        }

        private static int FindSmallest(int startNum, int endNum)
        {
            var smallestNum = int.MaxValue;

            if (startNum < endNum)
            {
                smallestNum = startNum;
            }
            else
            {
                smallestNum = endNum;
            }

            return smallestNum;
        }
    }
}
