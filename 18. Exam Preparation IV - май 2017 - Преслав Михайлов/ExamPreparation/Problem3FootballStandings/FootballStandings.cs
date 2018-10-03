using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3FootballStandings
{
    class FootballStandings
    {
        static void Main(string[] args)
        {
            var statistic = new Dictionary<string, int>();
            var goals = new Dictionary<string, int>();

            var key = Console.ReadLine();
            var input = Console.ReadLine();

            while (input != "final")
            {
                var tokens = input.Split();

                var firstPart = tokens[0];
                var firstIndexOfKey = firstPart.IndexOf(key);
                firstPart = firstPart.Substring(key.Length + firstIndexOfKey);
                var secondIndexOfKey = firstPart.IndexOf(key);
                firstPart = firstPart.Substring(0, secondIndexOfKey);
                var teamName1 = firstPart.ToUpper();
                teamName1 = Reverse(teamName1);

                var secondPart = tokens[1];
                firstIndexOfKey = secondPart.IndexOf(key);
                secondPart = secondPart.Substring(key.Length + firstIndexOfKey);
                secondIndexOfKey = secondPart.IndexOf(key);
                secondPart = secondPart.Substring(0, secondIndexOfKey);
                var teamName2 = secondPart.ToUpper();
                teamName2 = Reverse(teamName2);

                var lastPart = tokens[2].Split(':');
                var team1Score = int.Parse(lastPart[0]);
                var team2Score = int.Parse(lastPart[1]);

                if (!goals.ContainsKey(teamName1))
                {
                    goals.Add(teamName1, 0);
                }
                if (!goals.ContainsKey(teamName2))
                {
                    goals.Add(teamName2, 0);
                }
                goals[teamName1] += team1Score;
                goals[teamName2] += team2Score;

                if (team1Score == team2Score)
                {
                    team1Score = 1;
                    team2Score = 1;
                }
                else if (team1Score > team2Score)
                {
                    team1Score = 3;
                    team2Score = 0;
                }
                else
                {
                    team2Score = 3;
                    team1Score = 0;
                }

                if (!statistic.ContainsKey(teamName1))
                {
                    statistic.Add(teamName1, 0);
                }
                if (!statistic.ContainsKey(teamName2))
                {
                    statistic.Add(teamName2, 0);
                }
                statistic[teamName1] += team1Score;
                statistic[teamName2] += team2Score;

                input = Console.ReadLine();
            }
            var place = 1;

            Console.WriteLine("League standings:");
            foreach (var teams in statistic.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{place}. {teams.Key} {teams.Value}");
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var goal in goals.OrderByDescending(g => g.Value).ThenBy(g => g.Key).Take(3))
            {
                Console.WriteLine($"- {goal.Key} -> {goal.Value}");
            }
        }

        public static string Reverse(string teamName)
        {
            char[] charArray = teamName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
