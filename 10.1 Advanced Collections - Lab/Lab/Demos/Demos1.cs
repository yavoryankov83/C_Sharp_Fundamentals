using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Demos1
    {
        static void Main(string[] args)
        {
            var grades = new Dictionary<string, List<int>>();

            AddGrade("Pesho", 6, grades);
            AddGrade("Pesho", 4, grades);
            AddGrade("Pesho", 2, grades);

            AddGrade("Kiro", 2, grades);
            AddGrade("Kiro", 3, grades);
            AddGrade("Kiro", 5, grades);

            //first way to add grades
            //grades["Gosho"] = new List<int>();

            //grades["Gosho"].Add(6);
            //grades["Gosho"].Add(4);
            //grades["Gosho"].Add(2);

            foreach (var name in grades)
            {
                Console.WriteLine(name.Key + " -> " + string.Join(" ", name.Value));
            }
        }

        //second way to add grades - by using method
        public static void AddGrade(string name, int grade, Dictionary<string, List<int>> grades)
        {
            if (! grades.ContainsKey(name))
            {
                grades[name] = new List<int>();
            }

            grades[name].Add(grade);
        }
    }
}
