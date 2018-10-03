using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElements
{
    class ShootListElements
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            var command = Console.ReadLine();

            var lastRemoved = -1;

            var output = "";

            while (command != "stop")
            {
                if (command == "bang")
                {
                    if (list.Count == 0)
                    {
                        output = "nobody left to shoot! last one was {0}";
                        break;
                    }

                    int sum = SumElements(list);
                    double average = (double)sum / list.Count;

                    lastRemoved = ShootElement(list, average);

                    DecrementElements(list);
                }
                else
                {
                    var num = int.Parse(command);
                    list.Insert(0, num);
                }

                command = Console.ReadLine();
            }

            if (list.Count > 0 && output == "")
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", list));
            }
            else if(list.Count == 0 && output == "")
            {
                Console.WriteLine("you shot them all. last one was {0}", lastRemoved);
            }
            else
            {
                Console.WriteLine(output, lastRemoved);
            }
        }

        private static void DecrementElements(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i]--;
            }
        }

        private static int ShootElement(List<int> list, double average)
        {
            int result = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list.Count == 1)
                {
                    Console.WriteLine("shot {0}", list[0]);
                    result = list[0];
                    list.RemoveAt(0);
                    return result;
                }

                if (list[i] < average)
                {
                    Console.WriteLine("shot {0}", list[i]);
                    result = list[i];
                    list.RemoveAt(i);
                    break;
                }
            }
            return result;
        }

        private static int SumElements(List<int> list)
        {
            var sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }
    }
}
