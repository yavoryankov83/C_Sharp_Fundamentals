using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveEqualStrings
{
    class ConsecutiveEqualStrings
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var count = 0;

            for (int i = words.Length - 1; i > 0; i--)
            {
                if (words[i] == words[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                words[i] = words[i - 1];
                if (count == 2)
                {
                    Console.WriteLine("{0} {0} {0}", words[i]);
                    break;
                }
            }  
        }
    }
}
