using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.DebuggingExercisesTrickyStrings
{
    class DebuggingExercisesTrickyStrings
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            
            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var currentString = Console.ReadLine();

                if (i < n -1)
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
