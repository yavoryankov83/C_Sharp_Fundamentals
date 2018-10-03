using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ForumTopics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, HashSet<string>>();
            var result1 = new HashSet<string>();

            var line = Console.ReadLine();

            while (line != "filter")
            {
                var input = line.Split(new[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var topic = input[0];

                for (int i = 1; i < input.Length; i++)
                {
                    var tag = input[i];

                    if (!result.ContainsKey(topic))
                    {
                        result[topic] = new HashSet<string>();
                    }

                    result[topic].Add(tag);
                }

                line = Console.ReadLine();
            }

            var output = Console.ReadLine();
            var output1 = output.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < output1.Length; i++)
            {
                var word = output1[i];
                result1.Add(word);
            }

            foreach (var key in result)
            {
                var hasContain = false;

                foreach (var key1 in result1)
                {
                    if (key.Value.Contains(key1))
                    {
                        hasContain = true;

                    }
                    else
                    {
                        hasContain = false;
                        break;
                    }
                }

                if (hasContain)
                {
                    Console.WriteLine("{0} | #{1}", key.Key, string.Join(", #", key.Value));
                }
            }
        }
    }
}
