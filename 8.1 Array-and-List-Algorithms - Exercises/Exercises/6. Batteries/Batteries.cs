using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            var capacityList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var originals = new double[capacityList.Count];

            var remainHours = new int[capacityList.Count];

            capacityList.CopyTo(originals);

            var usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var hours = int.Parse(Console.ReadLine());

            var time = 1;

            while (time <= hours)
            {
                for (int i = 0; i < capacityList.Count; i++)
                {
                    if (capacityList[i] > 0)
                    {
                        capacityList[i] -= usagePerHour[i];

                        remainHours[i]++;
                    }
                }

                time++;
            }

            for (int i = 0; i < capacityList.Count; i++)
            {
                if (capacityList[i] > 0)
                {
                    double percentage = (capacityList[i] / originals[i]) * 100;

                    Console.WriteLine($"Battery {i + 1}: {capacityList[i]:F2} mAh ({percentage:F2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {remainHours[i]} hours)");
                }
            }
        }
    }
}
