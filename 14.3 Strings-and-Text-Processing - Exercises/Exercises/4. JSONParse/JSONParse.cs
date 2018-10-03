using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.JSONParse
{
    class JSONParse
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            input = input.Substring(2, input.Length - 2 - 2);

            var tokens = input
                .Split(new string[] { "},{" }, StringSplitOptions
                .RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                var properties = token
                    .Split(new string[] { ",age:", ",grades:"}, StringSplitOptions
                    .RemoveEmptyEntries);

                var name = properties[0]
                    .Substring(6, properties[0].Length - 6 - 1);
                var age = properties[1];
                var grades = properties[2]
                    .Substring(1, properties[2].Length - 1 - 1);

                if (grades == string.Empty)
                {
                    grades = "None";
                }

                Console.WriteLine($"{name} : {age} -> {grades}");
            }
        }
    }
}
