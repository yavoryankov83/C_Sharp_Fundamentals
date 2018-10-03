using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Nilapdromes
{
    class Nilapdromes
    {
        static void Main(string[] args)
        {
            //first way

            var input = Console.ReadLine();

            while (input != "end")
            {
                var nilapdrome = ReturnNilapdrome(input);

                if (nilapdrome != string.Empty)
                {
                    Console.WriteLine(nilapdrome);
                }

                input = Console.ReadLine();
            }

            //second way

            //var input = Console.ReadLine();

            //while (input != "end")
            //{
            //    var borderFirst = input.Substring(0, input.Length / 2);
            //    var borderSecond = string.Empty;
            //    var border = string.Empty;

            //    if (input.Length % 2 == 0)
            //    {
            //        borderSecond = input.Substring(borderFirst.Length, input.Length - borderFirst.Length);
            //    }
            //    else
            //    {
            //        borderSecond = input.Substring(borderFirst.Length + 1, input.Length - borderFirst.Length - 1);
            //    }

            //    while (true)
            //    {
            //        if (borderFirst == borderSecond)
            //        {
            //            border = borderFirst;
            //            break;
            //        }
            //        else if (borderFirst != borderSecond)
            //        {
            //            borderFirst = borderFirst.Substring(0, borderFirst.Length - 1);
            //            borderSecond = borderSecond.Substring(1, borderSecond.Length - 1);
            //        }

            //        if (borderFirst.Length == 0 && borderSecond.Length == 0)
            //        {
            //            break;
            //        }
            //    }

            //    if (border.Length != 0)
            //    {
            //        var core = input.Remove(input.Length - border.Length, border.Length).Trim();
            //        core = core.Remove(0, border.Length).Trim();
            //        if (core != "")
            //        {
            //            var nilapdromes = core + border + core;
            //            Console.WriteLine(nilapdromes);
            //        }
            //    }

            //    input = Console.ReadLine();
            //}
        }

        private static string ReturnNilapdrome(string input)
        {
            var middleIndex = input.Length / 2;

            var border = string.Empty;
            var leftIndex = 0;

            for (int i = middleIndex + 1; i < input.Length; i++)
            {
                if (input[leftIndex] == input[i])
                {
                    border += input[i];
                    leftIndex++;
                }
                else
                {
                    border = string.Empty;
                    leftIndex = 0;

                    if (input[i] == input[leftIndex])
                    {
                        border += input[i];
                        leftIndex++;
                    }
                }
            }
            if (border != string.Empty)
            {
                var leftIndexMiddle = input.IndexOf(border);
                var rightIndexMiddle = input.LastIndexOf(border);

                var middle = input
                    .Substring(leftIndexMiddle + border.Length
                    , rightIndexMiddle - leftIndexMiddle - border.Length);

                if (middle != string.Empty)
                {
                    return middle + border + middle;
                }
            }

            return string.Empty;
        }
    }
}
