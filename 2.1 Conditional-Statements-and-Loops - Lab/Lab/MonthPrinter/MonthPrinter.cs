using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthPrinter
{
    class MonthPrinter
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var month = "";

            switch (num)
            {
                case 1: month = "January";
                    break;
                case 2 :
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "Octomber";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "Desember";
                    break;
                default: month = "Error!";
                    break;
            }

            Console.WriteLine(month);
        }
    }
}
