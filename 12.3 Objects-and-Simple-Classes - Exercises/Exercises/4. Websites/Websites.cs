using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Websites
{
    class Websites
    {
        static void Main(string[] args)
        {
            var result = new List<Website>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var current = Website.ReadWebsite(input);
                result.Add(current);

                input = Console.ReadLine();
            }

            foreach (var res in result)
            {
                if (res.Queries.Count == 0)
                {
                    Console.WriteLine($"https://www.{res.Host}.{res.Domain}");
                }
                else
                {
                    Console.Write($"https://www.{res.Host}.{res.Domain}");
                    Console.Write($"/query?=");

                    var count = 1;

                    foreach (var que in res.Queries)
                    {
                        if (count == res.Queries.Count)
                        {
                            Console.Write($"[{que}]");
                        }
                        else
                        {
                            Console.Write($"[{que}]&");
                        }
                        count++;
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }

        public static Website ReadWebsite(string input)
        {
            var tokens = input
                .Split(new string[] { " | " }, StringSplitOptions
                .RemoveEmptyEntries);
            var host = tokens[0];
            var domain = tokens[1];
            var queries = new List<string>();

            if (tokens.Length > 2)
            {
                queries = tokens[2].Split(',').ToList();
            }
            
            return new Website
            {
                Host = host,
                Domain = domain,
                Queries = queries,
            };
        }
    }
}
