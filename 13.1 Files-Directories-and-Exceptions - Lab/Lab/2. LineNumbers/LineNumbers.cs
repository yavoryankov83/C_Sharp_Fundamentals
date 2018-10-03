using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("Input.txt");

            var output = input
                .Select((l, index) => $"{index + 1}. {l}");
            File.WriteAllLines("Output.txt", output);
        }
    }
}
