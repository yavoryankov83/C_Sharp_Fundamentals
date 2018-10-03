using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsEqualIndex
{
    class ElementsEqualIndex
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == i)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
