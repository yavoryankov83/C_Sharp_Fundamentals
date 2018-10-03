using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6.ReplaceTag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var pattern = "<a\\s*?href=\"(.+?)\">(\\w+)<\\/\\w>";

            Regex regex = new Regex(pattern);
            var input = Console.ReadLine();

            while (input != "end")
            {
                var replace = "[URL href=\"$1\"]$2[/URL]";
                var mached = regex.Replace(input, replace);
                result.Add(mached);

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
