using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split('|').ToList();
            list.Reverse();

            var result = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                var words = list[i].Split(' ').ToList();

                for (int j = 0; j < words.Count; j++)
                {
                    if (words[j] != "")
                    {
                        result.Add(words[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
