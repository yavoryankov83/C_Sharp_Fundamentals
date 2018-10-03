using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var commannd = Console.ReadLine();

            while (commannd != "end")
            {
                var tokens = commannd.Split();
                nums = ParseCommands(nums, tokens);

                commannd = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", nums));
        }

        private static List<int> ParseCommands(List<int> nums, string[] tokens)
        {
            switch (tokens[0])
            {
                case "exchange":
                    var index = int.Parse(tokens[1]);

                    if (index >= 0 && index < nums.Count)
                    {
                        nums = Exchange(nums, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case "max":
                    var odd = ParseInput(tokens[1]);
                    var max = Max(nums, odd);

                    if(max >= 0)
                    {
                        Console.WriteLine(max);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    break;

                case "min":
                    odd = ParseInput(tokens[1]);
                    var min = Min(nums, odd);

                    if (min >= 0)
                    {
                        Console.WriteLine(min);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    break;

                case "first":
                    var count = int.Parse(tokens[1]);
                    odd = ParseInput(tokens[2]);

                    if (count >= 0 && count <= nums.Count)
                    {
                        var first = First(nums, count, odd);
                        Console.WriteLine("[{0}]", string.Join(", ", first));
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                    break;

                case "last":
                    count = int.Parse(tokens[1]);
                    odd = ParseInput(tokens[2]);

                    if (count >= 0 && count <= nums.Count)
                    {
                        var last = Last(nums, count, odd);
                        Console.WriteLine("[{0}]", string.Join(", ", last));
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                    break;
            }

            return nums;
        }

        private static bool ParseInput(string tokens)
        {
            return tokens == "odd" ? true : false;
        }

        private static int Max(List<int> nums, bool odd)
        {
            int max;
            var expected = odd ? 1 : 0;

            var filteredElements = nums
                .Where(n => n % 2 == expected).ToList();

            if (filteredElements.Count > 0)
            {
                max = filteredElements
                .Max();
            }
            else
            {
                return -1;
            }

            return nums.LastIndexOf(max);
        }

        private static int Min(List<int> nums, bool odd)
        {
            int min;
            var expected = odd ? 1 : 0;

            var filteredElements = nums
                .Where(n => n % 2 == expected).ToList();

            if (filteredElements.Count > 0)
            {
                min = filteredElements
                .Min();
            }
            else
            {
                return -1;
            }

            return nums.LastIndexOf(min);
        }

        private static List<int> First(List<int> nums, int count, bool odd)
        {
            var expected = odd ? 1 : 0;

            var filteredElements = nums
                .Where(n => n % 2 == expected).ToList();

            var nums1 = filteredElements.Take(count).ToList();

            return nums1;
        }

        private static List<int> Last(List<int> nums, int count, bool odd)
        {
            var expected = odd ? 1 : 0;

            var filteredElements = nums
                .Where(n => n % 2 == expected).ToList();

            var nums1 = filteredElements.Skip(filteredElements.Count() - count).ToList();

            return nums1;
        }

        private static List<int> Exchange(List<int> nums, int index)
        {
            var first = nums
                .Take(index + 1);
            var second = nums
                .Skip(index + 1);
            nums = second
                .Concat(first)
                .ToList();

            return nums;
        }
    }
}
