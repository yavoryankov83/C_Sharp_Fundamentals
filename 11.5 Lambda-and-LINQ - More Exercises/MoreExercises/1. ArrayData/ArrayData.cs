using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ArrayData
{
    class ArrayData
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var command = Console.ReadLine();

            var result = nums.Where(x => x >= nums.Average());

            if (command == "Min")
            {
                var smallest = result.Min();
                Console.WriteLine(smallest);
            }
            else if (command == "Max")
            {
                var biggest = result.Max();
                Console.WriteLine(biggest);
            }
            else if(command == "All")
            {
                Console.WriteLine(string.Join(" ", result.OrderBy(x => x)));
            }
        }
    }
}
