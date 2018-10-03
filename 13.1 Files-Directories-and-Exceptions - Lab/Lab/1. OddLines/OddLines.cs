using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("Input.txt");

            for (int i = 1; i < input.Length; i += 2)
            {
                File.AppendAllText("Output.txt", input[i] + Environment.NewLine);
            }
        }
    }
}
