using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelsBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            var buildings = Console.ReadLine().Split(' ').ToList();

            var M = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 0; i < buildings.Count; i++)
            {
                while (buildings.Count > M)
                {
                    count++;
                    buildings.RemoveAt(0);
                    buildings.RemoveAt(buildings.Count - 1);
                }
            }

            if (count == 0)
            {
                Console.WriteLine("already stable: " + string.Join(" ", buildings));
            }
            else
            {
                Console.WriteLine($"{count} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", buildings));
            } 
        }
    }
}
