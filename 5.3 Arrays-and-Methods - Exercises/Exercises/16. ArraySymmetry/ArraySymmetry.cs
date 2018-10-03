using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();

            var isSimetrik = true;

            for (int i = 0; i < words.Count / 2; i++)
            {
                if (!(words[i] == words[words.Count - 1 - i]))
                {
                    isSimetrik = false;
                    break;
                }
            }
            Console.WriteLine(isSimetrik == true ? "Yes" : "No");
        }
    }
}
