using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < integers.Count; j++)
                {
                    if (nums.Contains(integers[j]))
                    {
                        nums.RemoveAll(item => item == integers[j]);
                    }
                    else
                    {
                        nums.Add(integers[j]);
                    }
                }
            }
            nums.Sort();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
