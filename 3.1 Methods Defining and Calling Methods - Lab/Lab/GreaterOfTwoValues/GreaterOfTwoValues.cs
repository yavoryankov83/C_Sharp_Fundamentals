using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var value1 = Console.ReadLine();
            var value2 = Console.ReadLine();

            if (type == "int")
            {
                var v1 = int.Parse(value1);
                var v2 = int.Parse(value2);

                var result = GetMax(v1, v2);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                var v1 = char.Parse(value1);
                var v2 = char.Parse(value2);

                var result = GetMax(v1, v2);
                Console.WriteLine(result);
            }
            else
            {
                var result = GetMax(value1, value2);
                Console.WriteLine(result);
            }
        }
        static int GetMax(int value1, int value2)
        {
            var max = value1;

            if (value2.CompareTo(value1) >= 0)
            {
                max = value2;
            }
           
            return max;
        }
        static char GetMax(char value1, char value2)
        {
            var max = value1;

            if (value2.CompareTo(value1) >= 0)
            {
                max = value2;
            }

            return max;
        }
        static string GetMax(string value1, string value2)
        {
            var max = value1;

            if (value2.CompareTo(value1) >= 0)
            {
                max = value2;
            }
            return max;
        }
    }
}
