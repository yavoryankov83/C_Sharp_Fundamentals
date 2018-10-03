using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumMinMaxAverage
{
    class SumMinMaxAverage
    {
        static void Main(string[] args)
        {
            var result = new List<int>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                result.Add(num);
            }
            var sum = result.Sum();
            var min = result.Min();
            var max = result.Max();
            var average = result.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
