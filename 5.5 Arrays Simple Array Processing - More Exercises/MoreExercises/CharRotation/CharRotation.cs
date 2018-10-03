using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToCharArray();
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    var ch = (int)str[i] - nums[i];
                    result.Add((char)ch);
                }
                else
                {
                    var ch = ((int)str[i] + nums[i]);
                    result.Add((char)ch);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
