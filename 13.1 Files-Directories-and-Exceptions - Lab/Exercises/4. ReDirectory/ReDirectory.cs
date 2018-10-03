using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ReDirectory
{
    class ReDirectory
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("input");

            foreach (var file in files)
            {
                var extension = file.Substring(file.LastIndexOf(".") + 1);

                if (!Directory.Exists($"{extension} + s"))
                {
                    Directory.CreateDirectory($"{extension} + s");
                }
                var name = file.Substring(file.LastIndexOf("\\"));

                Directory.Move(file, $"{extension} + s\\{name}");
            }
        }
    }
}
