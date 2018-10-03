using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.GreaterofTwoValues
{
    class GreaterofTwoValues
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    var num1 = int.Parse(Console.ReadLine());
                    var num2 = int.Parse(Console.ReadLine());
                    var result = GetMaxInt(num1, num2);
                    Console.WriteLine(result);
                    break;
                case "char":
                    var letter1 = char.Parse(Console.ReadLine());
                    var letter2 = char.Parse(Console.ReadLine());
                    var result1 = GetMaxChar(letter1, letter2);
                    Console.WriteLine(result1);
                    break;
                case "string":
                    var str1 = Console.ReadLine();
                    var str2 = Console.ReadLine();
                    var result2 = GetMaxString(str1, str2);
                    Console.WriteLine(result2);
                    break;
            }
        }

        private static string GetMaxString(string str1, string str2)
        {
            var max = string.Empty;

            if (str1.CompareTo(str2) > 0)
            {
                max = str1;
            }
            else
            {
                max = str2;
            }
            return max;
        }

        private static char GetMaxChar(char letter1, char letter2)
        {
            var max = letter1;

            if ((int)letter1 > (int)letter2)
            {
                max = letter1;
            }
            else
            {
                max = letter2;
            }
            return max;
        }

        private static int GetMaxInt(int num1, int num2)
        {
            var max = int.MinValue;
            if (num1 > max)
            {
                max = num1;
            }
            if(num2 > num1)
            {
                max = num2;
            }
            return max;
        }
    }
}
