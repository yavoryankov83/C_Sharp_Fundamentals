using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatrePromo
{
    class TheatrePromo
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var ticket = 0;

            if (day == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    ticket = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    ticket = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    ticket = 12;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            else if (day == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    ticket = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    ticket = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    ticket = 15;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            else if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    ticket = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    ticket = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    ticket = 10;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            Console.WriteLine($"{ticket}$");
        }
    }
}
