using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FolderSize
{
    class FolderSize
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("TestFolder");

            var sum = 0.0;

            foreach (var file in files)
            {
                FileInfo fileinfo = new FileInfo(file);
                sum += fileinfo.Length;
            }
            sum = sum / 1024 / 1024;

            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
