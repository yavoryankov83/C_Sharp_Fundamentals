using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ResizableArray
{
    class ResizableArray
    {
        static void Main(string[] args)
        {
            var result = new List<int>();

            var command = Console.ReadLine();

            while (command != "end")
            {
                if (command.Contains("push"))
                {
                    var line = command.Split();
                    var num = int.Parse(line[1]);
                    result.Add(num);
                }
                else if (command == "pop")
                {
                    result.RemoveAt(result.Count - 1);
                }
                else if (command.Contains("removeAt"))
                {
                    var line = command.Split();
                    var index = int.Parse(line[1]);
                    result.RemoveAt(index);
                }
                else if (command == "clear")
                {
                    result.RemoveRange(0, result.Count);
                }

                command = Console.ReadLine();
            }

            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty array");
            }
        }
    }
}
