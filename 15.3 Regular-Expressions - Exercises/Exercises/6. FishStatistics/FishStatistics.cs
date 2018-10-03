using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6.FishStatistics
{
    class FishStatistics
    {
        static void Main(string[] args)
        {
            var pattern = @">*<\(+['\-x]>";

            Regex fishPattern = new Regex(pattern);

            var input = Console.ReadLine();

            var fishes = fishPattern.Matches(input);
            var fishIndex = 1;

            foreach (Match fish in fishes)
            {
                var tailSize = 0;
                var bodySize = 0;
                var status = string.Empty;
                
                foreach (var symbol in fish.Value)
                {
                    if (symbol == '>')
                    {
                        tailSize++;
                    }
                    else if (symbol == '(')
                    {
                        bodySize++;
                    }
                    else if (symbol == '\'')
                    {
                        status = "Awake";
                    }
                    else if (symbol == '-')
                    {
                        status = "Asleep";
                    }
                    else if (symbol == 'x')
                    {
                        status = "Dead";
                    }
                }
                tailSize--;

                Console.WriteLine($"Fish {fishIndex}: {fish.Value}");
                Console.Write($"  Tail type: {GetTailType(tailSize)}");
                if (GetTailType(tailSize) != "None")
                {
                    Console.WriteLine($" ({tailSize * 2} cm)");
                }
                else
                {
                    Console.WriteLine();
                }
                Console.WriteLine($"  Body type: {GetBodyType(bodySize)} ({bodySize * 2} cm)");
                Console.WriteLine($"  Status: {status}");

                fishIndex++;
            }
            if (fishIndex == 1)
            {
                Console.WriteLine("No fish found.");
            }

        }
        static string GetTailType(int tailSize)
        {
            if (tailSize > 5)
            {
                return "Long";
            }
            else if (tailSize > 1)
            {
                return "Medium";
            }
            else if (tailSize == 1)
            {
                return "Short";
            }
            else
            {
                return "None";
            }
        }
        static string GetBodyType(int bodySize)
        {
            if (bodySize > 10)
            {
                return "Long";
            }
            else if (bodySize > 5)
            {
                return "Medium";
            }
            else
            {
                return "Short";
            }
        }
    }
}
