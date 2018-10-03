using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.IncreasingCrisis
{
    class IncreasingCrisis
    {
        static void Main(string[] args)
        {
            var result = new List<int>();

            int n = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            n--;
            input.Sort();
            result = input;

            while (n > 0)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int i = result.Count - 1; i >= 0; i--)
                {
                    if (result[i] <= input[0])
                    {
                        i++;
                        result.Insert(i, input[0]);

                        for (int k = 1; k < input.Count; k++)
                        {

                            if (input[k] >= input[k - 1])
                            {
                                i++;
                                result.Insert(i, input[k]);

                                if (i != result.Count - 1 && result[i] > result[i + 1])
                                {
                                    for (int p = i + 1; p < result.Count; p++)
                                    {
                                        result.RemoveAt(p);
                                        p--;
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                for (int p = i + 1; p < result.Count; p++)
                                {
                                    result.RemoveAt(p);
                                    p--;
                                }
                                break;
                            }
                        }
                        break;
                    }
                }

                n--;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
