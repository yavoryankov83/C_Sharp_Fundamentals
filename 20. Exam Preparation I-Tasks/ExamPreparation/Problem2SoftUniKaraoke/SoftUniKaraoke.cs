using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            var participantsList = new List<string>();
            var songsList = new List<string>();

            var result = new Dictionary<string, Dictionary<string, int>>();

            var participants = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries);

            for (int i = 0; i < participants.Length; i++)
            {
                participantsList.Add(participants[i]);
            }

            var songs = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries);

            for (int i = 0; i < songs.Length; i++)
            {
                songsList.Add(songs[i]);
            }

            var input = Console.ReadLine()
                .Split(new[] { ", ", }, StringSplitOptions
                .RemoveEmptyEntries);

            while (input[0] != "dawn")
            {
                var currentParticipant = input[0];
                var currentSong = input[1];
                var currentAward = input[2];

                if (participantsList.Contains(currentParticipant)
                    && songsList.Contains(currentSong))
                {
                    if (!result.ContainsKey(currentParticipant))
                    {
                        result.Add(currentParticipant, new Dictionary<string, int>());
                    }
                    if (!result[currentParticipant].ContainsKey(currentAward))
                    {
                        result[currentParticipant].Add(currentAward, 0);
                    }
                    result[currentParticipant][currentAward] = 1;
                }

                input = Console.ReadLine()
                .Split(new[] { ", ", }, StringSplitOptions
                .RemoveEmptyEntries);
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var pair in result
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenBy(x => x.Key))
            {
                var participant = pair.Key;
                var awardAndCount = pair.Value;


                Console.WriteLine($"{participant}: {result[participant].Values.Sum()} awards");

                foreach (var pair2 in awardAndCount.OrderBy(x => x.Key))
                {
                    var award = pair2.Key;
                    var count = pair2.Value;

                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
