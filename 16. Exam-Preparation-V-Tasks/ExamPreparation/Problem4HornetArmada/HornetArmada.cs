using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4HornetArmada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            var legionActivity = new Dictionary<string, int>();
            var legionSoldierCount = new Dictionary<string, Dictionary<string, long>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions
                    .RemoveEmptyEntries);

                var lastActivity = int.Parse(input[0]);
                var legioName = input[1];
                var soldierType = input[2];
                var soldierCount = int.Parse(input[3]);

                if (!legionActivity.ContainsKey(legioName))
                {
                    legionActivity.Add(legioName, lastActivity);
                    legionSoldierCount.Add(legioName, new Dictionary<string, long>());
                }
                if (!legionSoldierCount[legioName].ContainsKey(soldierType))
                {
                    //army_2[legioName].Add(soldierType, 0);
                    legionSoldierCount[legioName][soldierType] = 0;
                }
                if (legionActivity[legioName] < lastActivity)
                {
                    legionActivity[legioName] = lastActivity;
                }
                legionSoldierCount[legioName][soldierType] += soldierCount;
            }

            var conditions = Console.ReadLine().Split('\\');

            if (conditions.Length == 1)
            {
                var soldierType = conditions[0];

                foreach (var legionAndActivity in legionActivity
                    .OrderByDescending(a => a.Value))
                {
                    if (legionSoldierCount[legionAndActivity.Key]
                        .ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legionAndActivity.Value} : {legionAndActivity.Key}");
                    }

                }
            }
            else
            {
                var searchedActivity = int.Parse(conditions[0]);
                var searchedSoldiers = conditions[1];

                foreach (var nameTypeCount in legionSoldierCount
                    .Where(l => l.Value.ContainsKey(searchedSoldiers))
                    .OrderByDescending(l => l.Value[searchedSoldiers]))
                {
                    if (legionActivity[nameTypeCount.Key] < searchedActivity)
                    {
                        Console.WriteLine($"{nameTypeCount.Key} -> {nameTypeCount.Value[searchedSoldiers]}");
                    }
                }
            }
        }
    }
}
