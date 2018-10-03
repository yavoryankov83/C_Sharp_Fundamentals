using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            PrintRecipie();
        }

        private static void PrintRecipie()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------\n© SoftUni");
        }

        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
    }
}
