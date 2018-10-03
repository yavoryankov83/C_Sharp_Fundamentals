using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Pyramidic
{
    class Pyramidic
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            List<string> inputStrings = new List<string>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                inputStrings.Add(input);
            }

            for (int i = 0; i < inputStrings.Count; i++)
            {
                var currentString = inputStrings[i];

                for (int j = 0; j < currentString.Length; j++)
                {
                    char currentChar = currentString[j];

                    int layer = 1;
                    var currentPyramid = string.Empty;

                    for (int k = i; k < inputStrings.Count; k++)
                    {
                        string currentLayer = new string(currentChar, layer);

                        if (inputStrings[k].Contains(currentLayer))
                        {
                            currentPyramid += currentLayer + Environment.NewLine;
                        }
                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    result.Add(currentPyramid.Trim());
                }
            }
            Console.WriteLine(result.OrderByDescending(x => x.Length).First());
        }
    }
}
