using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSinceBirthday
{
    class TimeSinceBirthday
    {
        static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());
            var days = years * 365;
            var hours = days * 24;
            var minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");
        }
    }
}
