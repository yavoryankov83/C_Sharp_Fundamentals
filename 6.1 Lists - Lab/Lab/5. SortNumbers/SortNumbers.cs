﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            nums.Sort();

            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
