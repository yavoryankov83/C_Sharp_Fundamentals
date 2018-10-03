﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>();

            foreach (var num in nums)
            {
                if (Math.Sqrt(num) == ((int)(Math.Sqrt(num))))
                {
                    result.Add(num);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
