using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SplitbyWordCasing
{
    class SplitbyWordCasing
    {
        static void Main(string[] args)
        {
            var separator = new char[]
            { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            var text = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lower = new List<string>();
            var upper = new List<string>();
            var mixed = new List<string>();

            foreach (var word in text)
            {
                var countLower = 0;
                var countUpper = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        countLower++;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        countUpper++;
                    }
                }
                if (countLower == word.Length)
                {
                    lower.Add(word);
                }
                else if (countUpper == word.Length)
                {
                    upper.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lower));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixed));
            Console.WriteLine("Upper-case: " + string.Join(", ", upper));
        }
    }
}
