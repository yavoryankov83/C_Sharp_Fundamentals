using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var isSimetric = true;

            for (int i = 0; i < words.Length / 2; i++)
            {
                if (words[i] == words[words.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    isSimetric = false;
                    Console.WriteLine("No");
                    break;
                }
            }
            if (isSimetric == true)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
