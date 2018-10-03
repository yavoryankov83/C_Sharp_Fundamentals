using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem4CubicsMessages
{
    class CubicsMessages
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var lengthInput = int.Parse(Console.ReadLine());

            var validation = @"^\d+(?<message>[a-zA-Z]+)[^a-zA-Z]*$";
            Regex regex = new Regex(validation);

            while (input != "Over!")
            {
                var message = input;
                var length = lengthInput;

                var mached = regex.IsMatch(message);


                var mach = regex.Match(message);
                var encryptedMessage = mach.Groups["message"].Value;

                if (encryptedMessage.Length == length)
                {
                    StringBuilder builder = new StringBuilder();

                    foreach (char digit in message)
                    {
                        if (char.IsDigit(digit))
                        {
                            if (digit - '0' >= encryptedMessage.Length)
                            {
                                builder.Append(" ");
                            }
                            else
                            {
                                builder.Append(encryptedMessage[digit - '0']);
                            }
                        }
                    }

                    Console.WriteLine($"{encryptedMessage} == {builder}");
                }

                input = Console.ReadLine();

                if (input == "Over!")
                {
                    return;
                }

                lengthInput = int.Parse(Console.ReadLine());
            }
        }
    }
}
