using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.WordEncounter
{
    class WordEncounter
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var pattern = @"\b[a-zA-Z]+\b";

            Regex regex = new Regex(pattern);

            var str = Console.ReadLine();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input;
                if (char.IsUpper(tokens[0])
                    && (tokens[tokens.Length - 1].ToString() == "."
                    || tokens[tokens.Length - 1].ToString() == "?"
                    || tokens[tokens.Length - 1].ToString() == "!"))
                {
                    var mached = regex.Matches(tokens);

                    foreach (Match words in mached)
                    {
                        var currentWord = words.Value;
                        var count = 0;

                        for (int i = 0; i < currentWord.Length; i++)
                        {
                            if (currentWord[i].ToString() == str[0].ToString())
                            {
                                count++;
                            }
                            if (count >= int.Parse(str[1].ToString()))
                            {
                                result.Add(currentWord);
                                break;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
