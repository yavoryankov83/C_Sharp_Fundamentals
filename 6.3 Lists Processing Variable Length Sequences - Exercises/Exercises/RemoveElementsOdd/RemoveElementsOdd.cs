﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsOdd
{
    class RemoveElementsOdd
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();

            var result = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(words[i]);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
