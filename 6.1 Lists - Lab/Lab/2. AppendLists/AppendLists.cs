using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var line = Console.ReadLine().Split('|').Reverse().ToList();

            for (int i = 0; i < line.Count; i++)
            {
                var part = line[i].Split(' ').ToList();

                for (int j = 0; j < part.Count; j++)
                {
                    if (part[j] != string.Empty)
                    {
                        result.Add(part[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
