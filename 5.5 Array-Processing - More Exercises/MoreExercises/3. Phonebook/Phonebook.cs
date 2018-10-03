using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phones = Console.ReadLine().Split(' ').ToList();
            var names = Console.ReadLine().Split(' ').ToList();
            var command = Console.ReadLine();

            var result = new Dictionary<string, string>();

            for (int i = 0; i < phones.Count; i++)
            {
                result[names[i]] = phones[i];
            }

            while (command != "done")
            {
                if (result.ContainsKey(command))
                {
                    Console.WriteLine($"{command} -> {result[command]}");
                }

                command = Console.ReadLine();
            }
        }
    }
}
