using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var result = new SortedSet<string>();

            var blackList = Console.ReadLine().Split(' ').ToList();

            var fileNames = Console.ReadLine();

            while (fileNames != "end")
            {
                for (int i = 0; i < blackList.Count; i++)
                {
                    if (fileNames.Contains(blackList[i]))
                    {
                        break;
                    }
                    else if (!(fileNames.Contains(blackList[i])) && i == blackList.Count - 1)
                    {
                        result.Add(fileNames);
                    }
                }

                fileNames = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
