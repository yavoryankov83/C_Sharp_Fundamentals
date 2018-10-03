using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Entertrain
{
    class Entertrain
    {
        static void Main(string[] args)
        {
            var wagonList = new List<int>();

            var power = int.Parse(Console.ReadLine());

            var command = Console.ReadLine();

            while (command != "All ofboard!")
            {
                var currentWagon = int.Parse(command);
                wagonList.Add(currentWagon);

                var totalSum = wagonList.Sum();

                if (totalSum > power)
                {
                    var average = (int)(wagonList.Average());

                    var closestElement = FindClosest(wagonList, average);
                    wagonList.Remove(closestElement);
                }

                command = Console.ReadLine();
            }
            wagonList.Reverse();
            wagonList.Add(power);

            Console.WriteLine(string.Join(" ", wagonList));
        }

        private static int FindClosest(List<int> wagonList, int average)
        {
            int closestElement = -1;

            var result = wagonList.OrderBy(n => n).ToList();

            var previous = result.Where(n => n <= average).LastOrDefault();
            var next = result.Where(n => n > average).FirstOrDefault();

            if (previous == 0)
            {
                 return closestElement = next;
            }
            if (next == 0)
            {
                return closestElement = previous;
            }
            if (previous != 0 && next != 0)
            {
                var diff1 = average - previous;
                var diff2 = next - average;

                if (diff1 <= diff2)
                {
                     return closestElement = previous;
                }
                else
                {
                    return closestElement = next;
                }
            }
            return closestElement;
        }
    }
}
