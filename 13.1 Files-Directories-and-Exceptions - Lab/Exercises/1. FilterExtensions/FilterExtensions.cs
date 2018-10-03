using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FilterExtensions
{
    class FilterExtensions
    {
        static void Main(string[] args)
        {
            var fileExtencion = Console.ReadLine();

            var files = Directory.GetFiles("input");

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Contains(fileExtencion))
                {
                    FileInfo file = new FileInfo(files[i]);

                    Console.WriteLine(file.Name);
                }
            }
        }
    }
}
