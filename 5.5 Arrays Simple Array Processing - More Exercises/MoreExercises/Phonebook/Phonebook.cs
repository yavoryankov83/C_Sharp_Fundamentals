using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            var names = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                var str = Console.ReadLine();
                if (str == "done")
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (str == names[i])
                        {
                            Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                        }
                    }
                }
            }
        }
    }
}
