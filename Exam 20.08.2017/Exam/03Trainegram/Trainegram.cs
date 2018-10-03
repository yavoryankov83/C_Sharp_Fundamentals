using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03Trainegram
{
    class Trainegram
    {
        static void Main(string[] args)
        {
            var pattern = @"^(\<\[[^a-zA-Z0-9]*\]\.)((\.\[[a-zA-Z0-9]*\]\.)*)$";
            Regex regex = new Regex(pattern);

            var input = Console.ReadLine();

            while (input != "Traincode!")
            {
                var message = input;
                var match = regex.IsMatch(message);

                if (match)
                {
                    Console.WriteLine(message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
