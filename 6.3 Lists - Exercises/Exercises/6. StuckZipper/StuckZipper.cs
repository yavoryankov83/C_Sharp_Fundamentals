using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StuckZipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var line2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int smallest;

            var smallestNum1 = Math.Abs(line1
                .Min());

            var smallestNum2 = Math.Abs(line2
                .Min());

            if (smallestNum1 <= smallestNum2)
            {
                smallest = smallestNum1;
            }
            else
            {
                smallest = smallestNum2;
            }

            var length = smallest.ToString().Length;

            line1 = line1
                .Where(x => Math.Abs(x).ToString().Length <= length)
                .ToList();

            line2 = line2
                .Where(x => Math.Abs(x).ToString().Length <= length)
                .ToList();

            var countLine2 = line2.Count;

            var pow = 1;

            for (int i = 0; i < line1.Count; i++)
            {
                var current = line1[i];

                if (line1.Count > countLine2 && i >= countLine2)
                {
                    line2.Add(current);
                }
                else
                {
                    line2.Insert(pow, current);
                    pow += 2;
                }
            }

            Console.WriteLine(string.Join(" ", line2));
        }
    }
}
