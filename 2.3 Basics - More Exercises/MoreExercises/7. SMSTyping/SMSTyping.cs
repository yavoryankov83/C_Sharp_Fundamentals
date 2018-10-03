using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SMSTyping
{
    class SMSTyping
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var message = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var nums = int.Parse(Console.ReadLine());

                if (nums == 0)
                {
                    message += " ";
                }
                else
                {
                    int len = nums.ToString().Length;
                    int mainDigit = nums % 10;
                    int startIndex = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        startIndex++;
                    }

                    int letterIndex = startIndex + len - 1;
                    message += (char)(97 + letterIndex);
                }
            }
            Console.WriteLine(message);
        }
    }
}
