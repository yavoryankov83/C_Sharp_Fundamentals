using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPlura
{
    class WordPlura
    {
        static void Main(string[] args)
        {
            var noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                var result = noun.Remove(noun.Length - 1);
                Console.WriteLine(result + "ies");
            }
            else if (noun.EndsWith("o") || noun.EndsWith("s") || noun.EndsWith("x")
                || noun.EndsWith("z") || noun.EndsWith("ch") || noun.EndsWith("sh"))
            {
                var result = noun + "es";
                Console.WriteLine(result);
            }
            else
            {
                var result = noun + "s";
                Console.WriteLine(result);
            }
        }
    }
}
