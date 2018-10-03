using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var strings = Console.ReadLine();

            while (strings != "end")
            {
                var stringAsNum = int.Parse(strings);

                var index = 0;
                var num = stringAsNum;

                while (num >= 10)
                {
                    num /= 10;
                    index = num;
                }

                nums.Insert(index, stringAsNum);

                strings = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
