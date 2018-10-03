using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayStrings
{
    class SortArrayStrings
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            var swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < words.Length - 1; i++)
                {
                    var current = words[i];
                    var next = words[i + 1];

                    if (current.CompareTo(next) > 0)
                    {
                        words[i] = next;
                        words[i + 1] = current;

                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
