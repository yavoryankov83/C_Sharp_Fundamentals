using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var count = new int[1001];

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    count[nums[i]]++;
            //}

            //for (int i = 0; i < count.Length; i++)
            //{
            //    if (count[i] > 0)
            //    {
            //        Console.WriteLine($"{i} -> {count[i]}");
            //    }
            //}
            nums.Sort();
            nums.Add(int.MaxValue);

            var count = 1;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{nums[i]} -> {count}");
                    count = 1;
                }
            }
        }
    }
}
