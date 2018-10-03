using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCapitalLetters
{
    class CountCapitalLetters
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var count = 0;
            
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 1 && (char.IsUpper(words[i], 0)))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
