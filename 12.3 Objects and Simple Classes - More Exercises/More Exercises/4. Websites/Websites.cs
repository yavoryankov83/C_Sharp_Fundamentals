using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Websites
{
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }

    class Websites
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var line = input.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (line.Length > 2)
                {
                    var host = line[0];
                    var domain = line[1];
                    var Allqueries = line[2].Split(',').ToList();

                    var website = new Website();

                    website.Host = host;
                    website.Domain = domain;
                    website.Queries = Allqueries;
                }
                else
                {
                    var host = line[0];
                    var domain = line[1];
                }

                

                input = Console.ReadLine();
                
            }
        }
    }
}
