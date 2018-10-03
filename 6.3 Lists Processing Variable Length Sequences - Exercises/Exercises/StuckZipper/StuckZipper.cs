using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var copyList1 = new List<int>();
            var copyList2 = new List<int>();

            var minLengthList1 = int.MaxValue;
            var minLengthList2 = int.MaxValue;
            var min = 0;

            for (int i = 0; i < list1.Count; i++)
            {
                if ((Math.Abs(list1[i]).ToString()).Length < minLengthList1)
                {
                    minLengthList1 = (Math.Abs(list1[i]).ToString()).Length;
                }
            }

            for (int i = 0; i < list2.Count; i++)
            {
                if ((Math.Abs(list2[i]).ToString()).Length < minLengthList2)
                {
                    minLengthList2 = (Math.Abs(list2[i]).ToString()).Length;
                }
            }

            if (minLengthList1 < minLengthList2)
            {
                min = minLengthList1;
            }
            else
            {
                min = minLengthList2;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if ((Math.Abs(list1[i]).ToString()).Length <= min)
                {
                    copyList1.Add(list1[i]);
                }
            }

            for (int i = 0; i < list2.Count; i++)
            {
                if ((Math.Abs(list2[i])).ToString().Length <= min)
                {
                    copyList2.Add(list2[i]);
                }
            }

            if (copyList1.Count == 0)
            {
                Console.WriteLine(string.Join(" ", copyList2));
            }
            else if (copyList2.Count == 0)
            {
                Console.WriteLine(string.Join(" ", copyList1));
            }

            else if (copyList1.Count <= copyList2.Count)
            {
                var index = 1;

                for (int i = 0; i < copyList1.Count; i++)
                {
                    copyList2.Insert(index, copyList1[i]);

                    index += 2;
                }

                Console.WriteLine(string.Join(" ", copyList2));
            }
            else if (copyList1.Count > copyList2.Count)
            {
                var index = 0;

                for (int i = 0; i < copyList2.Count; i++)
                {
                    copyList1.Insert(index, copyList2[i]);

                    index += 2;
                }

                Console.WriteLine(string.Join(" ", copyList1));
            }
        }
    }
}
