using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            PrintTriangle(num);
        }
        static void PrintTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                PrintLine(i);
            }

            for (int i = num - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }
        static void PrintLine(int num, int strat = 1)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
