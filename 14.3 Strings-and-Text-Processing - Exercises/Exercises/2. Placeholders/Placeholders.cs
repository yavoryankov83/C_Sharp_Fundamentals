using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions
                    .RemoveEmptyEntries);

                var str = tokens[0];
                var elements = tokens[1].Split(new string[] { ", " }, StringSplitOptions
                    .RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    var plaseholder = "{" + i + "}";
                    str = str.Replace(plaseholder, elements[i]);
                }

                Console.WriteLine(str);

                input = Console.ReadLine();
            }
        }
    }
}
