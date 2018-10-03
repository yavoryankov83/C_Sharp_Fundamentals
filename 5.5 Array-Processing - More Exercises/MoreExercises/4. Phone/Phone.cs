using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Phone
{
    class Phone
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
                var input = command.Split();

                var dial = input[0];
                var namePhone = input[1];

                switch (dial)
                {
                    case "call":
                        if (result.ContainsKey(namePhone))
                        {
                            Console.WriteLine($"calling {result[namePhone]}...");

                            var digits = result[namePhone];

                            var sum = 0;

                            foreach (var digit in digits)
                            {
                                if (char.IsDigit(digit))
                                {
                                    sum += Convert.ToInt32(digit - '0');
                                }
                            }

                            if (sum % 2 != 0)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                Console.WriteLine($"call ended. duration: {(sum / 60):00}:{(sum % 60):00}");
                            }
                        }
                        else if (result.ContainsValue(namePhone))
                        {
                            Console.WriteLine($"calling {result.FirstOrDefault(x => x.Value == namePhone).Key}...");

                            var digits = namePhone;

                            var sum = 0;

                            foreach (var digit in digits)
                            {
                                if (char.IsDigit(digit))
                                {
                                    sum += Convert.ToInt32(digit - '0');
                                }
                            }

                            if (sum % 2 != 0)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                Console.WriteLine($"call ended. duration: {(sum / 60):00}:{(sum % 60):00}");
                            }
                        }
                        break;

                    case "message":
                        if (result.ContainsKey(namePhone))
                        {
                            Console.WriteLine($"sending sms to {result[namePhone]}...");

                            var digits = result[namePhone];

                            var difference = 0;

                            foreach (var digit in digits)
                            {
                                if (char.IsDigit(digit))
                                {
                                    difference -= Convert.ToInt32(digit - '0');
                                }
                            }

                            if (difference % 2 != 0)
                            {
                                Console.WriteLine("busy");
                            }
                            else
                            {
                                Console.WriteLine("meet me there");
                            }
                        }
                        else if (result.ContainsValue(namePhone))
                        {
                            Console.WriteLine($"sending sms to {result.FirstOrDefault(x => x.Value == namePhone).Key}...");

                            var digits = namePhone;

                            var difference = 0;

                            foreach (var digit in digits)
                            {
                                if (char.IsDigit(digit))
                                {
                                    difference -= Convert.ToInt32(digit - '0');
                                }
                            }

                            if (difference % 2 != 0)
                            {
                                Console.WriteLine("busy");
                            }
                            else
                            {
                                Console.WriteLine("meet me there");
                            }
                        }
                        break;
               }

                command = Console.ReadLine();
            }
        }
    }
}
