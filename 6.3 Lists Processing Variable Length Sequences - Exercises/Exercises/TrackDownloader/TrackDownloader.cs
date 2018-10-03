using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();

            var result = new List<string>();

            while (true)
            {
                var filename = Console.ReadLine();

                if (filename == "end")
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < words.Count; i++)
                    {
                        if (filename.Contains(words[i]))
                        {
                            break;
                        }
                        else if (!(filename.Contains(words[i])) && i == words.Count - 1)
                        {
                            result.Add(filename);
                        }
                    }
                }
            }
            result.Sort();
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
