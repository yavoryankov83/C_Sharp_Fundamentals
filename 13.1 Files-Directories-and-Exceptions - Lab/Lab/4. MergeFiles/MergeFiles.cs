using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            var file1 = File.ReadAllLines("FileOne.txt");
            var file2 = File.ReadAllLines("FileTwo.txt");

            using (StreamWriter writer = new StreamWriter("Output.txt"))
            {
                for (int i = 0; i < file1.Length; i++)
                {
                    writer.WriteLine($"{file1[i]}{Environment.NewLine}{file2[i]}");
                }
            }
        }
    }
}
