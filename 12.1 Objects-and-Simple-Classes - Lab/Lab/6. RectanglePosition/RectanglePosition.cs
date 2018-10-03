using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var input2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Rectangle firstRectangle = 
                new Rectangle(input1[0], input1[1], input1[2], input1[3]);

            Rectangle secondRectangle = 
                new Rectangle(input2[0], input2[1], input2[2], input2[3]);

            if (firstRectangle.IsInsideSecond(secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool IsInsideSecond(Rectangle second)
        {
            return Top >= second.Top &&
                Left >= second.Left &&
                Bottom <= second.Bottom &&
                Right <= second.Right;
        }

        public Rectangle (int left, int top, int width, int height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }
    }
}
