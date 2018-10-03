using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.TrickyStrings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            var delimeter = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var words = Console.ReadLine();

                if (i < n - 1)
                {
                    result += words + delimeter;
                }
                else
                {
                    result += words;
                }
                
            }
            Console.WriteLine(result);
        }
    }
}
