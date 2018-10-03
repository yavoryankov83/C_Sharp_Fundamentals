using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.OrderedBankingSystem
{
    class OrderedBankingSystem
    {
        static void Main(string[] args)
        {
            var bankBase = new Dictionary<string, Dictionary<string, decimal>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions
                    .RemoveEmptyEntries);

                var bankName = tokens[0];
                var accountName = tokens[1];
                var balance = decimal.Parse(tokens[2]);

                if (!bankBase.ContainsKey(bankName))
                {
                    bankBase.Add(bankName, new Dictionary<string, decimal>());
                }

                if (!bankBase[bankName].ContainsKey(accountName))
                {
                    bankBase[bankName].Add(accountName, 0);
                }

                bankBase[bankName][accountName] += balance;

                input = Console.ReadLine();
            }

            //sort data
            var orderedData = bankBase
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(a => a.Value.Values.Max());

            foreach (var pair in orderedData)
            {
                var bankName = pair.Key;
                var accountNameAndBalance = pair.Value;

                var ordersedAccountsData = accountNameAndBalance
                    .OrderByDescending(x => x.Value);

                foreach (var pair2 in ordersedAccountsData)
                {
                    var accountName = pair2.Key;
                    var balance = pair2.Value;

                    Console.WriteLine($"{accountName} -> {balance} ({bankName})");
                }
            }
        }
    }
}
