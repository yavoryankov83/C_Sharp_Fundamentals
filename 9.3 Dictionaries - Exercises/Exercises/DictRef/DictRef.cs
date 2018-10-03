using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRef
{
    class DictRef
    {
        static void Main(string[] args)
        {
            var doubles = Console.ReadLine();

            var result = new Dictionary<string, int>();

            while (doubles != "end")
            {
                var tokens = doubles.Split();

                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var number = 0;

                if (int.TryParse(lastElement, out number))
                {
                    result[firstElement] = number;
                }
                else
                {
                    if (result.ContainsKey(lastElement))
                    {
                        var referenceValue = result[lastElement];
                        result[firstElement] = referenceValue;
                    }
                }

                doubles = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
