using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStrings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            
            var result = string.Empty;

            for (int i = 0; i < numberOfStrings; i++)
            {
                var currentString = Console.ReadLine();
                if (i < numberOfStrings - 1)
                {
                    result += currentString + delimiter;
                }
                else
                {
                    result += currentString;
                }
            }
            Console.WriteLine(result);
        }
    }
}
