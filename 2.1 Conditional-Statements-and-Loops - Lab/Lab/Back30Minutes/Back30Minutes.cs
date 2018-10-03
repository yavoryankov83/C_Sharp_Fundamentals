using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back30Minutes
{
    class Back30Minutes
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var hoursInMinutes = hours * 60;

            var time = hoursInMinutes + minutes + 30;

            var hoursTime = time / 60;
            var minutesTime = time % 60;
                
            if (hoursTime >= 24)
            {
                hoursTime = hoursTime - 24;
            }

            if (minutesTime >= 60)
            {
                minutesTime = minutesTime - 60;
            }
            
                var min = "0" + minutesTime;

            Console.WriteLine("{0}:{1}", hoursTime, minutesTime < 10 ? min : $"{minutesTime}");
        }
    }
}
