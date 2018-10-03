using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem4WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            var ticketList = Console.ReadLine()
                .Split(new[] { ',', ' ', '\t' }, StringSplitOptions
                .RemoveEmptyEntries);

            var patternWinningTicket = @"([$]{6,}|[@]{6,}|[\^]{6,}|[#]{6,})";
            var patternJackpot = @"([$]{20}|[@]{20}|[\^]20}|[#]{20})";

            Regex winning = new Regex(patternWinningTicket);
            Regex jackpot = new Regex(patternJackpot);

            foreach (var ticket in ticketList)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    if (jackpot.IsMatch(ticket))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!");
                        continue;
                    }
                    else if (!winning.IsMatch(ticket))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                        continue;
                    }
                    else if (winning.IsMatch(ticket))
                    {
                        var lesftPart = ticket.Substring(0, 10);
                        var rightPart = ticket.Substring(10);

                        var leftMatch = winning.Match(lesftPart).ToString();
                        var rightMatch = winning.Match(rightPart).ToString();

                        if (!(winning.IsMatch(leftMatch) && winning.IsMatch(rightMatch)))
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                        else
                        {
                            if (leftMatch[0] == rightMatch[0] && leftMatch.Length <= rightMatch.Length)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {leftMatch.Length}{leftMatch[0]}");
                            }
                            else if (leftMatch[0] == rightMatch[0] && leftMatch.Length > rightMatch.Length)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {rightMatch.Length}{rightMatch[0]}");
                            }
                            else if (leftMatch[0] != rightMatch[0])
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - no match");
                                continue;
                            }
                        }
                    }

                }
            }
        }
    }
}
