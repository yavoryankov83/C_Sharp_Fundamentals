using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numberToFind = int.Parse(Console.ReadLine());

            var isFound = nums.Contains(numberToFind);

            if (isFound)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            LinearSearch(nums, numberToFind);

            BinarySearch1(nums, numberToFind);

        }

        private static void BinarySearch1(List<int> nums, int numberToFind)
        {
            var min = 0;
            var max = nums.Count - 1;
            var iritations = 0;
            nums.Sort();
            nums.Distinct();

            while (min <= max)
            {
                var mid = (min + max) / 2;

                iritations++;

                if (numberToFind == nums[mid])
                {
                    Console.WriteLine($"Binary search made {iritations} iterations");
                    return;
                }
                else if (numberToFind < nums[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine($"Binary search made {iritations} iterations");
        }

        private static void LinearSearch(List<int> nums, int number)
        {
            var iritations = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                iritations++;

                if (nums[i] == number)
                {
                    Console.WriteLine($"Linear search made {iritations} iterations");
                    return;
                }
            }
            Console.WriteLine($"Linear search made {iritations} iterations");
        } 
    }
}
