using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherRoulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var result = string.Empty;
            var previousWord = string.Empty;
            var concatenateToEnd = true;

            for (int i = 0; i < count; i++)
            {
                var currentWord = Console.ReadLine();
                
                if (currentWord == "spin")
                {
                    concatenateToEnd = false;
                    i--;
                }

                switch (concatenateToEnd)
                {
                    case (true): result += currentWord;
                        break;
                    case (false): result = currentWord + result;
                        break;
                }

                if (currentWord == previousWord)
                {
                    result = string.Empty;

                    if (currentWord == "spin")
                    {
                        concatenateToEnd = false;
                    }
                    previousWord = currentWord;
                }

                previousWord = currentWord;
            }

            result = result.Replace("spin", string.Empty);

            Console.WriteLine(result);
        }
    }
}
