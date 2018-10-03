using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem2HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            var privates = new List<string>();
            var broadcasts = new List<string>();

            var tokens = Console.ReadLine()
                .Split(new string[] { " <-> " }, StringSplitOptions
                .RemoveEmptyEntries); ;

            while (tokens[0] != "Hornet is Green")
            {
                if (tokens.Length != 2)
                {
                    tokens = Console.ReadLine()
                    .Split(new string[] { " <-> " }, StringSplitOptions
                    .RemoveEmptyEntries); ;

                    continue;
                }
                var firstPart = tokens[0];
                var secondPart = tokens[1];

                if (firstPart.All(char.IsDigit) && secondPart.All(char.IsLetterOrDigit))
                {
                    var code = secondPart;
                    var message = string.Empty;
                    for (int i = firstPart.Length - 1; i >= 0; i--)
                    {
                        message += firstPart[i];
                    }

                    privates.Add($"{message} -> {code}");
                }

                if (firstPart.All(c => !char.IsDigit(c)) && secondPart.All(char.IsLetterOrDigit))
                {
                    var message = firstPart;
                    var frequency = secondPart;
                    var decodeFrequency = string.Empty;

                    foreach (var freq in frequency)
                    {
                        if (char.IsUpper(freq))
                        {
                            decodeFrequency += char.ToLower(freq);
                        }
                        else if (char.IsLower(freq))
                        {
                            decodeFrequency += char.ToUpper(freq);
                        }
                        else
                        {
                            decodeFrequency += freq;
                        }
                    }
                    broadcasts.Add($"{decodeFrequency} -> {message}");
                }

                tokens = Console.ReadLine()
                    .Split(new string[] { " <-> " }, StringSplitOptions
                    .RemoveEmptyEntries); ;
            }

            Console.WriteLine($"Broadcasts:");

            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, broadcasts));
            }

            Console.WriteLine($"Messages:");

            if (privates.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, privates));
            }
        }
    }
}
