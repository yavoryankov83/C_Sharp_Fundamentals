using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OptimizedBankingSystem
{
    class OptimizedBankingSystem
    {
        static void Main(string[] args)
        {
            var result = new List<BankAccount>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var current = BankAccount.ReadInput(input);
                result.Add(current);

                input = Console.ReadLine();
            }

            var accounts = result
                .OrderByDescending(c => c.Balance)
                .ThenBy(c => c.Name.Length);

            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.Bank} -> {account.Balance} ({account.Name})");
            }
        }
    }
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }

        public static BankAccount ReadInput(string input)
        {
            var tokens = input
                .Split(new string[] { " | " }, StringSplitOptions
                .RemoveEmptyEntries);
            var name = tokens[0];
            var bank = tokens[1];
            var balance = decimal.Parse(tokens[2]);

            return new BankAccount
            {
                Name = name,
                Bank = bank,
                Balance = balance,
            };
        }
    }
}
