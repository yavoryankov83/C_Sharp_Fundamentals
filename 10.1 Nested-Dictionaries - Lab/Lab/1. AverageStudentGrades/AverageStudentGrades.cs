using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var name = input[0];
                var grade = double.Parse(input[1]);

                if (!result.ContainsKey(name))
                {
                    result.Add(name, new List<double>());
                }
                result[name].Add(grade);
            }

            foreach (var pair in result)
            {
                var name = pair.Key;
                var grades = pair.Value;

                var average = grades
                    .Average();

                var formated = grades.Select(a => string.Format("{0:F2}", a));

                Console.WriteLine($"{name} -> {string.Join(" ", formated)} (avg: {average:F2})");
            }
        }
    }
}
