using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OptimizedBanking
{
    class BankAccount
    {
        public string AccountName { get; set; }

        public string Bank{ get; set; }

        public decimal AccountBalance { get; set; }
    }

    class OptimizedBankingSystem
    {
        static void Main(string[] args)
        {
            var result = new List<BankAccount>();

            var input = Console.ReadLine();
            
            while (input != "end")
            {
                var line = input
                    .Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var bank = line[0];
                var accountName = line[1];
                var accountBalance = decimal.Parse(line[2]);

                var newBankAccount = new BankAccount()
                {
                    Bank = bank,    
                    AccountName = accountName,
                    AccountBalance = accountBalance
                };

                result.Add(newBankAccount);

                input = Console.ReadLine();
            }

            result = result
                .OrderByDescending(x => x.AccountBalance)
                .ThenBy(x => x.Bank.Length)
                .ToList();

            foreach (var bank in result)
            {
                Console.WriteLine($"{bank.AccountName} -> {bank.AccountBalance} ({bank.Bank})");
            }
        }
    }
}
