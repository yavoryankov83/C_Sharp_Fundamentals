using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                var str = Console.ReadLine();

                if (str == "end")
                {
                    break;
                }
                else
                {
                    var num = Convert.ToInt32(str);
                    while (num > 9)
                    {
                        num /= 10;
                    }
                    nums.Insert(num, Convert.ToInt32(str));
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
