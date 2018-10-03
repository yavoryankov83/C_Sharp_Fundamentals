using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            var names = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                var str = Console.ReadLine();
                if (str == "done")
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (str == $"call {phoneNumbers[i]}")
                        {
                            Console.WriteLine($"calling {names[i]}...");
                        }
                        else if (str == $"call {names[i]}")
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...");
                        }
                        else if (str == $"message {phoneNumbers[i]}")
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");
                        }
                        else if (str == $"message {names[i]}")
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                        }

                        var sumOfNumbers = 0;
                        var phone = phoneNumbers[i];
                        for (int j = 0; j < phone.Length; j++)
                        {
                            if (phone[j] != '+' && phone[j] != '-' && phone[j] != '(' && phone[j] != ')')
                            {
                                sumOfNumbers += phone[j] - '0';
                            }
                        }

                        if (sumOfNumbers % 2 == 1)
                        {
                            if (str == $"call {phoneNumbers[i]}" || str == $"call {names[i]}")
                            {
                                Console.WriteLine("no answer");
                            }
                            else if (str == $"message {phoneNumbers[i]}" || str == $"message {names[i]}")
                            {
                                Console.WriteLine("busy");
                            }
                        }
                        else
                        {
                            if (str == $"call {phoneNumbers[i]}" || str == $"call {names[i]}")
                            {
                                Console.WriteLine($"call ended. duration: {(sumOfNumbers / 60).ToString("00")}:{(sumOfNumbers % 60).ToString("00")}");
                            }
                            else if (str == $"message {phoneNumbers[i]}" || str == $"message {names[i]}")
                            {
                                Console.WriteLine("meet me there");
                            }
                            
                        }
                    }
                }
            }
        }
    }
}
