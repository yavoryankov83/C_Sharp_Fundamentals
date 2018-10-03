using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SoftUniBeerPong
{
    class SoftUniBeerPong
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();

            while (input != "stop the game")
            {
                var tokens = input.Split('|');

                var player = tokens[0];
                var team = tokens[1];
                var score = long.Parse(tokens[2]);

                if (!result.ContainsKey(team))
                {
                    result.Add(team, new Dictionary<string, long>());
                }

                if (result[team].Count < 3)
                {
                    result[team].Add(player, score);
                }
                
                input = Console.ReadLine();
            }

            var rang = 1;

            foreach (var pair in result.OrderByDescending(x => x.Value.Sum(p => p.Value)))
            {
                var team = pair.Key;
                var playerAndScore = pair.Value;

                if (playerAndScore.Count == 3)
                {
                    Console.WriteLine($"{rang}. {team}; Players:");

                    rang++;

                    foreach (var pair1 in playerAndScore.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"###{pair1.Key}: {pair1.Value}");
                    }
                }
            }
        }
    }
}
