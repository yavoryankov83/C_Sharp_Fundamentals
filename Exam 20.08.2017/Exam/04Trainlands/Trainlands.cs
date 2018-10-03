using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04Trainlands
{
    class Trainlands
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, int>>();

            var first = Console.ReadLine();

            var input = first
                .Split(new[] { " -> ", " : ", " = " }, StringSplitOptions
                .RemoveEmptyEntries);

            var pattern = @"[a-zA-Z]+ = [a-zA-Z]+";
            Regex regex = new Regex(pattern);

            while (first != "It's Training Men!")
            {
                if (input.Length == 3)
                {
                    var trainName = input[0];
                    var wagonName = input[1];
                    var wagonPower = int.Parse(input[2]);

                    if (!result.ContainsKey(trainName))
                    {
                        result.Add(trainName, new Dictionary<string, int>());
                    }
                    if (!result[trainName].ContainsKey(wagonName))
                    {
                        result[trainName].Add(wagonName, 0);
                    }
                    result[trainName][wagonName] = wagonPower;
                }
                else if (input.Length == 2)
                {
                    if (!regex.IsMatch(first))
                    {
                        var trainName = input[0];
                        var otherTrainName = input[1];

                        if (!result.ContainsKey(trainName))
                        {
                            result.Add(trainName, new Dictionary<string, int>());
                        }
                        foreach (var pair in result[otherTrainName])
                        {
                            result[trainName].Add(pair.Key, pair.Value);
                        }
                        result.Remove(otherTrainName);
                    }
                    else
                    {
                        var trainName = input[0];
                        var otherTrainName = input[1];

                        if (!result.ContainsKey(trainName))
                        {
                            result.Add(trainName, new Dictionary<string, int>());
                        }
                        result.Remove(trainName);
                        result.Add(trainName, new Dictionary<string, int>());

                        foreach (var pair in result[otherTrainName])
                        {
                            result[trainName].Add(pair.Key, pair.Value);
                        }
                    }
                }

                first = Console.ReadLine();

                input = first
                    .Split(new[] { " -> ", " : ", " = " }, StringSplitOptions
                    .RemoveEmptyEntries);
            }

            foreach (var pair in result
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(y => y.Key.Count()))
            {
                var trainName = pair.Key;
                var wagonAndPower = pair.Value;

                Console.WriteLine($"Train: {trainName}");

                foreach (var pair2 in wagonAndPower
                    .OrderByDescending(x => x.Value))
                {
                    var wagon = pair2.Key;
                    var power = pair2.Value;

                    Console.WriteLine($"###{wagon} - {power}");
                }
            }
        }
    }
}
