using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PointsCounter
{
    class PointsCounter
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, List<Player>>();

            var input = Console.ReadLine();

            while (input != "Result")
            {
                var inputed = input
               .Replace("@", string.Empty)
               .Replace("%", string.Empty)
               .Replace("$", string.Empty)
               .Replace("*", string.Empty);

                var tokens = inputed
                    .Split(new[] { '|' }, StringSplitOptions
                    .RemoveEmptyEntries);

                string team;
                string player;
                var points = int.Parse(tokens[2]);

                var token = tokens[0];

                if (token.Equals(token.ToUpper()))
                {
                    team = token;
                    player = tokens[1];
                }
                else
                {
                    player = token;
                    team = tokens[1];
                }

                var footballPlayer = new Player(player, points);

                if (!result.ContainsKey(team))
                {
                    result.Add(team, new List<Player>());
                }
                if (result[team].Contains(new Player(player, points)))
                {
                    var index = result[team].IndexOf(new Player(player, points));
                    result[team][index].Points = points;
                }
                else
                {
                    result[team].Add(new Player(player, points));
                }

                input = Console.ReadLine();
            }

            var orderedData = result
                .OrderByDescending(x => x.Value.Sum(p => p.Points));

            foreach (var players in orderedData)
            {
                
                var team = players.Key;
                var playerData = players.Value;

                var totalPoints = playerData.Sum(x => x.Points);
                var bestPlayer = playerData.OrderByDescending(p => p.Points).First();

                Console.WriteLine($"{team} => {totalPoints}");
                Console.WriteLine($"Most points scored by {bestPlayer.Name}");
            }
        }
    }
    class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public override bool Equals(object obj)
        {
            if (obj is Player)
            {
                Player other = (Player)obj;

                return this.Name == other.Name;
            }

            return false;
        }
    }
}
