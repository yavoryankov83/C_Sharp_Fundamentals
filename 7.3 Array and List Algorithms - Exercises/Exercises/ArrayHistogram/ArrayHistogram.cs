using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');

            var foundWords = new List<string>();
            var wordsCount = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (foundWords.Contains(words[i]))
                {
                    int index = foundWords.IndexOf(words[i]);
                    wordsCount[index]++;
                }
                else
                {
                    foundWords.Add(words[i]);
                    wordsCount.Add(1);
                }
            }

            //BUBBLE SORT
            var isSwapped = true;

            while (isSwapped)
            {
                isSwapped = false;

                for (int i = 0; i < wordsCount.Count - 1; i++)
                {
                    if (wordsCount[i] < wordsCount[i + 1])
                    {
                        int temp = wordsCount[i];
                        wordsCount[i] = wordsCount[i + 1];
                        wordsCount[i + 1] = temp;

                        var tempWord = foundWords[i];
                        foundWords[i] = foundWords[i + 1];
                        foundWords[i + 1] = tempWord;

                        isSwapped = true;
                    }
                }
            }

            //SELECTION SORT
            //for (int i = 0; i < wordsCount.Count; i++)
            //{
            //    for (int j = 0; j < wordsCount.Count; j++)
            //    {
            //        if (wordsCount[i] > wordsCount[j])
            //        {
            //            int temp = wordsCount[i];
            //            wordsCount[i] = wordsCount[j];
            //            wordsCount[j] = temp;

            //            var tempWord = foundWords[i];
            //            foundWords[i] = foundWords[j];
            //            foundWords[j] = tempWord;
            //        }
            //    }
            //}

            for (int i = 0; i < foundWords.Count; i++)
            {
                var percentage = (double)wordsCount[i] / words.Length;

                Console.WriteLine($"{foundWords[i]} -> {wordsCount[i]} times ({percentage.ToString("0.00%")})");
            }
        }
    }  
}
