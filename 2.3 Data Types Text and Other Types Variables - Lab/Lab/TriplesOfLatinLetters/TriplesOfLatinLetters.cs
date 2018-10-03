using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < number + 'a'; i++)
            {
                for (char j = 'a'; j < number + 'a'; j++)
                {
                    for (char k = 'a'; k < number + 'a'; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
