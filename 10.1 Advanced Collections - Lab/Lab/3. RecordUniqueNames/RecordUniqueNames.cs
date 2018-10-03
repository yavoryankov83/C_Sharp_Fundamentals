using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();

                result.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
