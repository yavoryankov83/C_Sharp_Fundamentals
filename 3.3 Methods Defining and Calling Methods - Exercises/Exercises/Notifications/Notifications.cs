using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var result = Console.ReadLine();

                if (result == "success")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();

                    var str = ShowSuccess(operation, message);
                    Console.WriteLine(str);
                }

                else if (result == "error")
                {
                    var operation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());

                    var str = ShowError(operation, code);
                    Console.WriteLine(str);
                }
                else
                {
                    continue;
                }
            }
        }

        static string ShowSuccess(string operation, string message)
        {
            var str = $@"Successfully executed {operation}.
==============================
Message: {message}.";

            return str;
        }

        static string ShowError(string operation, int code)
        {
            var reason = string.Empty;

            if (code > 0 )
            {
                reason = "Invalid Client Data";
            }
            else if (code < 0 )
            {
                reason = "Internal System Failure";
            }
            var str = $@"Error: Failed to execute {operation}.
==============================
Error Code: {code}.
Reason: {reason}.";

            return str;
        }


    }
}
