using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumExtraction
{
    class EqualSumExtraction
    {
        static void Main(string[] args)
        {
            var nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < nums1.Count; i++)
            {
                sum1 += nums1[i];

                if (nums2.Contains(nums1[i]))
                {
                    nums2.Remove(nums1[i]);
                }
            }
            for (int i = 0; i < nums2.Count; i++)
            {
                sum2 += nums2[i];
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum1}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
