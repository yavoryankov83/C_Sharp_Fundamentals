using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Winecraft
{
    class Winecraft
    {
        static int[] grapes;
        static void Main(string[] args)
        {
            grapes = Console.ReadLine().Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var n = int.Parse(Console.ReadLine());

            do
            {
                for (int i = 0; i < n; i++)
                {
                    BloomGrapes();
                }

                KillGrapesWithPowerLesserThan(n);

            } while (StrongGrapesAreGreaterOrEqualThan(n));

            PrintLiveGrapes();
        }

        private static void PrintLiveGrapes()
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                if (isAlive(i))
                {
                    Console.Write(grapes[i] + " ");
                }
            }

            Console.WriteLine();
        }

        static bool isAlive(int index)
        {
            if (index < 0 || index >= grapes.Length)
            {
                return false;
            }
            return grapes[index] > 0;
        }

        private static void KillGrapesWithPowerLesserThan(int threshold)
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                if (grapes[i] <= threshold)
                {
                    grapes[i] = 0;
                }
            }
        }

        static bool StrongGrapesAreGreaterOrEqualThan(int threshold)
        {
            return grapes
                .Where(e => e > threshold)
                .Count() >= threshold;
        }

        private static void BloomGrapes()
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                if (isAlive(i))
                {
                    continue;
                }
                if (isGreaterGrape(i))
                {
                    grapes[i]++;
                    if (isAlive(i - 1))
                    {
                        grapes[i]++;
                        grapes[i - 1]--;
                    }
                    if (isAlive(i + 1))
                    {
                        grapes[i]++;
                        grapes[i - 1]--;
                    }
                }
                else if (isLesserGrape(i))
                {
                    
                }
                else
                {
                    grapes[i]++;
                }
            }
        }
        static bool isGreaterGrape(int index)
        {
            if (index < 0 || index >= (grapes.Length - 1))
            {
                return false;
            }

            return (grapes[index] > grapes[index - 1] &&
                grapes[index] > grapes[index + 1]);
        }

        static bool isLesserGrape(int index)
        {
            return (isGreaterGrape(index - 1) ||
                isGreaterGrape(index + 1));
        }
    }
}

