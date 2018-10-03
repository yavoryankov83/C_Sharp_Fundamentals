using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Game
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var count = 0;
            var lastMagyc = "";
            var isMagyc = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    count++;

                    if (i + j == magicNum)
                    {
                        lastMagyc = ($"Number found! {i} + {j} = {magicNum}");
                        isMagyc = true;
                    }
                }
            }
            if (isMagyc)
            {
                Console.WriteLine(lastMagyc);
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
