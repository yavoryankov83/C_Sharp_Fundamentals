using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Exercises
{
    class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }
    }

    class Exercises
    {
        static void Main(string[] args)
        {
            var exercises = new List<Exercise>();

            var input = Console.ReadLine();
                
            while (input != "go go go")
            {
                var line = input
                    .Split(new char[] { ' ', '-', '>', '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var topic = line[0];
                var courseName = line[1];
                var judgeContestLink = line[2];
                var problems = line.Skip(3).ToList();

                Exercise newExercise = new Exercise()
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContestLink = judgeContestLink,
                    Problems = problems
                };

                exercises.Add(newExercise);

                input = Console.ReadLine();
            }

            foreach (var ex in exercises)
            {
                Console.WriteLine($"Exercises: {ex.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{ex.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {ex.JudgeContestLink}");

                var count = 1;

                foreach (var problem in ex.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }
        }
    }
}
