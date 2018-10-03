using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split(' ').ToArray();

            var result = Convert.ToInt32(commands[0]);

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    result += Convert.ToInt32(commands[i + 1]);
                }
                else if (commands[i] == "down")
                {
                    result -= Convert.ToInt32(commands[i + 1]);
                }
                if (result <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            Console.WriteLine($"got through safely. current altitude: {result}m");
        }
    }
}
