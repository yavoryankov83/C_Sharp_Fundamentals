﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLet
{
    class MagicLet
    {
        static void Main(string[] args)
        {
            var letter1 = char.Parse(Console.ReadLine());
            var letter2 = char.Parse(Console.ReadLine());
            var letter3 = char.Parse(Console.ReadLine());

            for (char i = letter1; i <= letter2; i++)
            {
                for (char j = letter1; j <= letter2; j++)
                {
                    for (char k = letter1; k <= letter2; k++)
                    {
                        if (i != letter3 && j != letter3 && k != letter3)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
