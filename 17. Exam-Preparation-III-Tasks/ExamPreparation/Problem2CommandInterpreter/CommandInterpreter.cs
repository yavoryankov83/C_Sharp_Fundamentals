using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            var collection = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input
                    .Split(new[] { ' ' }, StringSplitOptions
                    .RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "reverse":
                        ReverseList(tokens, collection);
                        break;

                    case "sort":
                        SortList(tokens, collection);
                        
                        break;

                    case "rollLeft":
                        RollLeft(tokens, collection);

                        break;

                    case "rollRight":
                        RollRight(tokens, collection);

                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", collection)}]");
        }

        private static void ReverseList(string[] tokens, List<string> collection)
        {
            var index = int.Parse(tokens[2]);
            var count = int.Parse(tokens[4]);

            if (index < 0 || index >= collection.Count || count < 0 || index + count > collection.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            collection.Reverse(index, count);
        }

        private static void SortList(string[] tokens, List<string> collection)
        {
            var index = int.Parse(tokens[2]);
            var count = int.Parse(tokens[4]);

            if (index < 0 || index >= collection.Count || count < 0 || index + count > collection.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            collection.Sort(index, count, StringComparer.InvariantCulture);
        }

        private static void RollLeft(string[] tokens, List<string> collection)
        {
            int count = int.Parse(tokens[1]) % collection.Count;

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                var firstElement = collection[0];
                collection.RemoveAt(0);
                collection.Add(firstElement);
            }
        }

        private static void RollRight(string[] tokens, List<string> collection)
        {
            int count = int.Parse(tokens[1]) % collection.Count;

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                var lastElement = collection[collection.Count - 1];
                collection.RemoveAt(collection.Count - 1);
                collection.Insert(0, lastElement);
            }
        }
    }
}
