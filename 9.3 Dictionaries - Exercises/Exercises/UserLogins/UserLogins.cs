using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var output = new Dictionary<string, string>();

            var output1 = new Dictionary<string, string>();

            while (input != "login")
            {
                var userNamePassword = input.Split(' ');

                if (!output.ContainsKey(userNamePassword[0]))
                {
                    output.Add(userNamePassword[0], userNamePassword[userNamePassword.Length - 1]);
                }
                else
                {
                    output[userNamePassword[0]] = userNamePassword[userNamePassword.Length - 1];
                }

                userNamePassword = input.Split(' ');

                if (input == "login")
                {
                    break;
                }
            }

            while (input != "end")
            {
                var userNamePassword = input.Split(' ');

                if (!output1.ContainsKey(userNamePassword[0]))
                {
                    output1.Add(userNamePassword[0], userNamePassword[userNamePassword.Length - 1]);
                }
                else
                {
                    output1[userNamePassword[0]] = userNamePassword[userNamePassword.Length - 1];
                }

                foreach (var item in output1)
                {
                    if (item == output[item])
                    {

                    }
                }

                userNamePassword = input.Split(' ');
            }
        }
    }
}
