using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CypherRoulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;
            string lastStr = string.Empty;

            bool addToEnd = true;

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();

                if (str.Equals(lastStr))
                {
                    if (str.Equals("spin"))
                    {
                        result = string.Empty;
                        i--;
                        continue;
                    }

                    result = string.Empty;
                    continue;
                }

                lastStr = str;

                if (str.Equals("spin"))
                {
                    addToEnd = !addToEnd;
                    i--;
                }
                else if (addToEnd == true)
                {
                    result += str;
                }
                else if (addToEnd == false)
                {
                    result = str + result;
                }
            }

            Console.WriteLine(result);
        }
    }
}
