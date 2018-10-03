using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            var phones = Console.ReadLine();

            var phoneBook = new SortedDictionary<string, long>();

            while (phones != "Over")
            {
                var phonesSeparated = phones.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = phonesSeparated[0];
                var phoneNumber = phonesSeparated[1];

                long number;
                var parced = long.TryParse(name, out number);

                if (!parced)
                {
                    phoneBook.Add(name, Convert.ToInt64(phoneNumber));
                }
                else
                {
                    phoneBook.Add(phoneNumber, Convert.ToInt64(name));
                }

                phones = Console.ReadLine();
            }

            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
