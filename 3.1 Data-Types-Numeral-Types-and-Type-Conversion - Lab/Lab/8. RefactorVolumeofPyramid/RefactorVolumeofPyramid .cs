﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.RefactorVolumeofPyramid
{
    class ProgRefactorVolumeofPyramid
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            var heigth = double.Parse(Console.ReadLine());

            var volume = (length * width * heigth) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
