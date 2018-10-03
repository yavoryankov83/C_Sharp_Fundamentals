using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.SoftUniMessages
{
    class SoftUniMessages
    {
        static void Main(string[] args)
        {
            var pattern = @"^\d+(?<message>[A-Za-z]+)[^a-zA-Z]+$";
            Regex regex = new Regex(pattern);

            var input = Console.ReadLine();

            while (input != "Decrypt!")
            {
                var num = int.Parse(Console.ReadLine());

                if (regex.IsMatch(input))
                {
                    var m = regex.Match(input);
                    var message = m.Groups["message"].Value;

                    if (message.Length == num)
                    {
                        var decodeMessage = DecodeMessage(input, message);

                        Console.WriteLine($"{message} = {decodeMessage}");
                    }
                }

                input = Console.ReadLine();
            }
        }
        static string DecodeMessage(string input, string message)
        {
            var result = string.Empty;

            foreach (var @char in input)
            {
                var index = @char - '0';
                if (char.IsDigit(@char) && index < message.Length)
                {
                    result += message[@char - '0'];
                }
            }

            return result;
        }
    }
}
