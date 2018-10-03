using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Textfilter
{
    class Textfilter
    {
        static void Main(string[] args)
        {
            var banList = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions
                .RemoveEmptyEntries);

            var text = Console.ReadLine();

            foreach (var word in banList)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
