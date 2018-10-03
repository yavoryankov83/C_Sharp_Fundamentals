﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            var NumberCounts = int.Parse(Console.ReadLine());


            for (int i = 0; i < NumberCounts; i++)
            {

                var SuccessOrError = Console.ReadLine();

                if (SuccessOrError == "success")
                {
                    string Soperation = Console.ReadLine();
                    string Smessage = Console.ReadLine();
                    string success = ShowSuccess(Soperation, Smessage);

                    Console.WriteLine(success);
                }

                else if (SuccessOrError == "error")
                {
                    string Eoperation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());
                    string error = ShowError(Eoperation, code);

                    Console.WriteLine(error);

                }

            }

        }

        public static string ShowSuccess(string operation, string message)
        {
            return $"Successfully executed {operation}.\n==============================\nMessage: {message}.";

        }


        public static string ShowError(string operation, int code)
        {
            if (code > 0)
            {

                return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Invalid Client Data.";
            }

            else
            {
                return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Internal System Failure.";
            }
        }
    }
}
