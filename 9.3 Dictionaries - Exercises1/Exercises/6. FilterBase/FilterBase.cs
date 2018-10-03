using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            var namesAndAges = new Dictionary<string, int>();
            var namesAndSalaries = new Dictionary<string, double>();
            var namesAndPositions = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "filter base")
            {
                var tokens = input.Split(' ');

                var name = tokens[0];
                var secondPart = tokens[2];

                var age = 0;
                var parcedToInt = int.TryParse(secondPart, out age);

                var salary = 0.0;
                var parcedToDouble = double.TryParse(secondPart, out salary);

                if (parcedToInt)
                {
                    if (!namesAndAges.ContainsKey(name))
                    {
                        namesAndAges.Add(name, age);
                    }
                    else
                    {
                        namesAndAges[name] = age;
                    }
                }

                if (parcedToDouble)
                {
                    if (!namesAndSalaries.ContainsKey(name))
                    {
                        namesAndSalaries.Add(name, salary);
                    }
                    else
                    {
                        namesAndSalaries[name] = salary;
                    }
                }

                else
                {
                    if (!namesAndPositions.ContainsKey(name))
                    {
                        namesAndPositions.Add(name, secondPart);
                    }
                    else
                    {
                        namesAndPositions[name] = secondPart;
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            if (input == "Age")
            {
                foreach (var pair in namesAndAges)
                {
                    Console.WriteLine($"Name: {pair.Key}");
                    Console.WriteLine($"Age: {pair.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (input == "Salary")
            {
                foreach (var pair in namesAndSalaries)
                {
                    Console.WriteLine($"Name: {pair.Key}");
                    Console.WriteLine($"Salary: {pair.Value:F2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (input == "Position")
            {
                foreach (var pair in namesAndPositions)
                {
                    Console.WriteLine($"Name: {pair.Key}");
                    Console.WriteLine($"Position: {pair.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
