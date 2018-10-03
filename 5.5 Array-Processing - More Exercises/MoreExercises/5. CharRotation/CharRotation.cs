using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CharRotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToList();
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var symbol = string.Empty;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {       
                    symbol += (char)((int)words[i] - nums[i]);
                }
                else
                {
                    symbol += (char)((int)words[i] + nums[i]);
                }
            }
            Console.WriteLine(symbol);
        }
    }
}
