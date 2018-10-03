using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignLang
{
    class ForeignLang
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();

            var language = "";

            if (country == "England" || country == "USA")
            {
                language = "English";
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                language = "Spanish";
            }
            else
            {
                language = "unknown";
            }

            Console.WriteLine(language);
        }
    }
}
