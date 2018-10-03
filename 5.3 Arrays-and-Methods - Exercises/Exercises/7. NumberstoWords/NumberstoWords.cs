using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumberstoWords
{
    class NumberstoWords
    {
        static void Main(string[] args)
        {
            var one = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeeen",
               "eighteen", "nineteen" };
            var ten = new string[] { null, null, "twenty", "thirty", "forty",
                "fifty", "sixty", "seventy", "eighty", "ninety" };

            var n = int.Parse(Console.ReadLine());

            var sign = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (num < -999)
                {
                    Console.WriteLine("too small");
                }
                else if (Math.Abs(num).ToString().Length < 3)
                {
                    continue;
                }
                else
                {
                    var positive = Math.Abs(num);

                    int hundreds = positive / 100;
                    int tens = (positive / 10) % 10;
                    int ones = positive % 10;
                    var result = string.Empty;

                    if (hundreds == 0)
                    {
                        if (tens == 0)
                        {
                            result = one[ones];
                        }
                        else
                        {
                            if (tens == 1)
                            {
                                result = teens[ones];
                            }
                            else
                            {
                                result = ten[tens];

                                if (ones > 0)
                                {
                                    result += " " + one[ones];
                                }
                            }
                        }
                    }
                    else
                    {
                        result = one[hundreds] + "-hundred";

                        if (tens == 0)
                        {
                            if (ones != 0)
                            {
                                result += " and " + one[ones];
                            }
                        }
                        else
                        {
                            if (tens == 1)
                            {
                                result += " and " + teens[ones];
                            }
                            else
                            {
                                result += " and " + ten[tens];

                                if (ones > 0)
                                {
                                    result += " " + one[ones];
                                }
                            }
                        }
                    }
                    if (num < 0)
                    {
                        Console.WriteLine("minus " + result);
                    }
                    else
                    {
                        Console.WriteLine(result);
                    }
                }
            }
        } 
    }
}
