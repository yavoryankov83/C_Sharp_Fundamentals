using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<string>();

            var pattern = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";

            var numbers = Console.ReadLine();

            var regex = new Regex(pattern);

            var maches = regex.Matches(numbers);

            foreach (Match phone in maches)
            {
                phoneBook.Add(phone.Value);
            }
            Console.WriteLine(string.Join(", ", phoneBook));
        }
    }
}
