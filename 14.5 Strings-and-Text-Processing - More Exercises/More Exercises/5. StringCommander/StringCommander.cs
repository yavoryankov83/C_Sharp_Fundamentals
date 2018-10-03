using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.StringCommander
{
    class StringCommander
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            var commands = Console.ReadLine();

            while (commands != "end")
            {
                var tokens = commands
                    .Split(new[] { ' ' }, StringSplitOptions
                    .RemoveEmptyEntries);

                if (tokens[0] == "Left")
                {
                    var count = int.Parse(tokens[1]);

                    count %= str.Length;
                    str = str.Substring(count)
                        + str.Substring(0, count);
                }
                else if (tokens[0] == "Right")
                {
                    var count = int.Parse(tokens[1]);

                    count %= str.Length;
                    str = str
                        .Substring(str.Length - count)
                        + str.Substring(0, str.Length - count);
                }
                else if (tokens[0] == "Insert")
                {
                    var index = int.Parse(tokens[1]);
                    var stringa = tokens[2];

                    str = str.Insert(index, stringa);
                }
                else if (tokens[0] == "Delete")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);

                    str = str.Remove(startIndex, endIndex - startIndex + 1);
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine(str);
        }
    }
}
