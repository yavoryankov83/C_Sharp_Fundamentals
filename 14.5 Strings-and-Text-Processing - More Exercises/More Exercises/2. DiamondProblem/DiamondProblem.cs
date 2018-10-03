using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.DiamondProblem
{
    class DiamondProblem
    {
        static void Main(string[] args)
        {
            //var result = new List<string>();

            //var input = Console.ReadLine();

            //var pattern = @"\D+";
            //var regex = new Regex(pattern);

            //while (input.Length > 0)
            //{
            //    var firstIndexOf0 = input.IndexOf("<");
            //    var firstIndexOf1 = input.IndexOf(">");

            //    if (firstIndexOf0 == -1 
            //        || firstIndexOf1 == -1 
            //        || (firstIndexOf1 - firstIndexOf0 - 1) <= 0)
            //    {
            //        Console.WriteLine("Better luck next time");
            //        return;
            //    }

            //    var firstSub = input.Substring(firstIndexOf0 + 1, firstIndexOf1 - firstIndexOf0 - 1);

            //    result.Add(firstSub);

            //    input = input.Remove(0, firstIndexOf1 + 1);
            //}

            //foreach (var diamond in result)
            //{
            //    var sum = 0;

            //    for (int i = 0; i < diamond.Length; i++)
            //    {
            //        if (char.IsDigit(diamond[i]))
            //        {
            //            sum += int.Parse(diamond[i].ToString());
            //        }
            //    }
            //    var match = regex.Match(diamond);
            //    var mached = match.Value;

            //    if (!(diamond == mached) && sum > 0)
            //    {
            //        Console.WriteLine($"Found {sum} carat diamond");
            //    }
            //}
            string input = Console.ReadLine();

            bool isDiam = false;

            int startIndex = input.IndexOf("<");
            while (startIndex != -1)
            {
                int endIndex;
                string diamond = string.Empty;

                endIndex = input.IndexOf(">", startIndex + 1);

                if (endIndex - startIndex > 0)
                {
                    diamond = input.Substring(startIndex + 1, endIndex - startIndex - 1);
                }

                startIndex = input.IndexOf("<", startIndex + 1);

                int sum = 0;
                for (int i = 0; i < diamond.Length; i++)
                {
                    if (Char.IsDigit(diamond[i]))
                    {
                        sum += diamond[i] - '0';
                    }
                }
                if (sum > 0)
                {
                    Console.WriteLine($"Found {sum} carat diamond");
                    isDiam = true;
                }
            }

            if (!isDiam)
            {
                Console.WriteLine("Better luck next time");
            }
        }
    }
}
