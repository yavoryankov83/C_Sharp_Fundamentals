﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ClosestTwoPoints
{
    class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
}
