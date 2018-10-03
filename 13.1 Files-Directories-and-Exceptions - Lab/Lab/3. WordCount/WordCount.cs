using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();

            var wordsToSearchFor = File.ReadAllText("words.txt").ToLower().Split();

            var spliters = new char[] { '\n', '\r', ' ', ',', '.', '!', '?', '-' };
            var text = File.ReadAllText("text.txt")
                .ToLower().Split(spliters, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in wordsToSearchFor)
            {
                result[word] = 0;
            }
            foreach (var word in text)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
            }

            var words = result
                .OrderByDescending(w => w.Value);

            foreach (var pair in words)
            {
                File.AppendAllText("Output.txt", string.Format($"{pair.Key} - {pair.Value} {Environment.NewLine}"));
            }
        }
    }
}
