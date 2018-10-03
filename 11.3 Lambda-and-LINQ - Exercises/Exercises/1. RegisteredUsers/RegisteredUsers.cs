using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.RegisteredUsers
{
    class RegisteredUsers
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, DateTime>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var username = tokens[0];
                var date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!result.ContainsKey(username))
                {
                    result.Add(username, date);
                }

                result[username] = date;

                input = Console.ReadLine();
            }

            foreach (var pair in result.Reverse().OrderBy(d => d.Value).Take(5).OrderByDescending(d => d.Value))
            {
                Console.WriteLine($"{pair.Key}");
            }
        }
    }
}
