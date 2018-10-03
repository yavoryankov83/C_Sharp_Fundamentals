using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class NumbersToWords
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var str = string.Empty;
            var array = new List<string>();

            for (int i = 0; i < num; i++)
            {
                var nums = int.Parse(Console.ReadLine());

                str = Letterize(nums);

                if (str != string.Empty)
                {
                    array.Add(str);
                }
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static string Letterize(int nums)
        {
            var ones = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var tens = new string[] { null, null, "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            var teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeeen", "eighteen", "nineteen" };

            var str = string.Empty;

            if (nums > 999)
            {
                str += "too large";
                return str;
            }
            else if (nums < -999)
            {
                str += "too small";
                return str;
            }
            else
            {
                if (nums <= 99 && nums >= -99)
                {
                    return str;
                }

                else if (nums < -99 && nums >= -999)
                {
                    str += "minus ";
                }
                else
                {
                    str = string.Empty;
                }
            }
            
            var hundred = Math.Abs(nums / 100);
            var ten = Math.Abs((nums / 10) % 10);
            var one = Math.Abs(nums % 10);

            if (hundred == 0)
            {
                if (ten == 0)
                {
                    str += ones[one];
                }
                else
                {
                    if (ten == 1)
                    {
                        str += teens[one];
                    }
                    else
                    {
                        str += tens[ten];

                        if (one > 0)
                        {
                            str += " " + ones[one];
                        }
                    }
                }
            }
            else
            {
                str += ones[hundred] + "-hundred";

                if (ten == 0)
                {
                    if (one != 0)
                    {
                        str += " and " + ones[one];
                    }
                }
                else
                {
                    if (ten == 1)
                    {
                        str+= " and " + teens[one];
                    }
                    else
                    {
                        str+= " and " + tens[ten];

                        if (one > 0)
                        {
                            str += " " + ones[one];
                        }
                    }
                }
            }
            
            return str;
        }
    }
}
