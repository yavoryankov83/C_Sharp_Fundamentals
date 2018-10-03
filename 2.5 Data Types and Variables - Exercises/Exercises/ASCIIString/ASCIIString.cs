using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIString
{
    class ASCIIString
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var str = "";

            for (int i = 0; i < count; i++)
            {
                var nums = int.Parse(Console.ReadLine());
                str += (char)nums;
            }
            Console.WriteLine(str);
        }
    }
}
