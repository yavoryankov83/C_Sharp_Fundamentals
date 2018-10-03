using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HTMLContents
{
    class HTMLContents
    {
        static void Main(string[] args)
        {
            var path = "output.html";
            File.AppendAllText(path, "<!DOCTYPE html>\r\n");
            File.AppendAllText(path, "<html>\r\n");
            File.AppendAllText(path, "<head>\r\n");

            var title = string.Empty;

            var bodyContent = new List<string[]>();

            while (true)
            {
                var tokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim())
                    .ToArray();

                if (tokens[0] == "exit")
                {
                    break;
                }
                else if (tokens[0] == "title")
                {
                    title = tokens[1];
                }
                else
                {
                    bodyContent.Add(tokens);
                }
            }

            File.AppendAllText(path, $"\t<title>{title}</title>\r\n");
            File.AppendAllText(path, "</head>\r\n");
            File.AppendAllText(path, "<body>\r\n");

            foreach (var tag in bodyContent)
            {
                File.AppendAllText(path, $"/t<{tag[0]}>{tag[1]}</{tag[0]}>/r/n");
            }
            File.AppendAllText(path, "</body>\r\n");
            File.AppendAllText(path, "</html>\r\n");
        }
    }
}
