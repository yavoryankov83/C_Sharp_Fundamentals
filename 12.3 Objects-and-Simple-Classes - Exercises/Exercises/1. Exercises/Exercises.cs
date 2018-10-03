using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Exercises
{
    class Exercises
    {
        static void Main(string[] args)
        {
            var result = new List<Exercise>();

            var input = Console.ReadLine();

            while (input != "go go go")
            {
                var current = Exercise.ReadInput(input);
                result.Add(current);

                input = Console.ReadLine();
            }
            
            foreach (var res in result)
            {
                Console.WriteLine($"Exercises: {res.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{res.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {res.JudgeContestLink}");

                var count = 1;

                foreach (var prob in res.Problems)
                {
                    Console.WriteLine($"{count}. {prob}");
                    count++;
                }
                
            }
        }
    }
    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public string[] Problems { get; set; }

        public static Exercise ReadInput(string input)
        {
            var tokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions
                    .RemoveEmptyEntries);
            var topic = tokens[0];
            var courseName = tokens[1];
            var judgeContestLink = tokens[2];
            var problems = tokens[3];
            var listProblems = problems
                .Split(new string[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries);

            return new Exercise
            {
                Topic = topic,
                CourseName = courseName,
                JudgeContestLink = judgeContestLink,
                Problems = listProblems,
            };
        }
    }
}
