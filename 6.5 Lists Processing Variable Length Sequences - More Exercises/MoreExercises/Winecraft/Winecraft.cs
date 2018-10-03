using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft
{
    class Winecraft
    {
        static void Main(string[] args)
        {
            var grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var growthDays = int.Parse(Console.ReadLine());

            while (grapes.Count > growthDays)
            {
                for (int i = 0; i < growthDays; i++)
                {
                    for (int j = 0; j < grapes.Count; j++)
                    {
                        grapes[j]++;
                    }
                    for (int j = 0; j < grapes.Count; j++)
                    {
                        if (j != 0 && j != grapes.Count - 1)
                        {
                            if (grapes[j] > grapes[j - 1] && grapes[j] > grapes[j + 1])
                            {
                                grapes[j]--;

                                if (grapes[j - 1] > 0)
                                {
                                    grapes[j]++;
                                    grapes[j - 1] = Math.Max(grapes[j - 1] - 2, 0);
                                }
                                if (grapes[j + 1] > 0)
                                {
                                    grapes[j]++;
                                    grapes[j + 1] = Math.Max(grapes[j + 1] - 2, 0);
                                }
                            }
                        }

                    }
                }
                for (int j = 0; j < grapes.Count; j++)
                {
                    if (grapes[j] < growthDays)
                    {
                        grapes.RemoveAt(j);
                        j--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", grapes));
        }
    }
}
