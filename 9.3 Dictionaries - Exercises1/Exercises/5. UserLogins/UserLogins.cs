using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, string>();

            var count = 0;

            var input = Console.ReadLine();

            while (input != "login")
            {
                var command = input.Split(' ');

                var username = command[0];
                var password = command[2];

                if (!result.ContainsKey(username))
                {
                    result.Add(username, password);
                }
                else
                {
                    result[username] = password;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end")
            {
                var command = input.Split(' ');

                var username = command[0];
                var password = command[2];

                if (result.ContainsKey(username) && result[username] == password)
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
                else
                {
                    count++;
                    Console.WriteLine($"{username}: login failed");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
