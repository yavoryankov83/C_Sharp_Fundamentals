using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStrings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            var delimeter = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var result = "";

            for (int i = 0; i < count; i++)
            {
                var words = Console.ReadLine();
                if (i == count - 1)
                {
                    result += words;
                }
                else
                {
                    result += words + delimeter;
                }
            }
            Console.WriteLine(result);
        }
    }
}
