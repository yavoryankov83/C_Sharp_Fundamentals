using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var result = new List<char>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var num = numbers[i].ToString().Split('.');

                for (int j = 0;  j < num.Length;  j++)
                {
                    if (num[j] != "0" || num[j + 1] != "0")
                    {
                        if (j == 0)
                        {
                            var leftinteger = Convert.ToInt32(num[j]);
                            result.Insert(i, (char)leftinteger);
                        }
                        else
                        {
                            var rightinteger = Convert.ToInt32(num[j]);
                            result.Insert(result.Count - i - 1, (char)rightinteger);
                        }
                    }
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
