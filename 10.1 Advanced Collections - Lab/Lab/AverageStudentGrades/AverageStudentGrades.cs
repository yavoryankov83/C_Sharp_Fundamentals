using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {

            var record = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var name = input[0];
                var grade = double.Parse(input[1]);

                if (! record.ContainsKey(name))
                {
                    record[name] = new List<double>();
                }

                record[name].Add(grade);
            }

            foreach (var nameAndGrade in record)
            {
                var name = nameAndGrade.Key;
                var grade = nameAndGrade.Value;
                var average = grade.Average();

                var formated = grade.Select(a => string.Format("{0:F2}", a));

                Console.WriteLine("{0} -> {1} (avg: {2:F2})", name, string.Join(" ", formated), average);
            }
        }
    }
}
