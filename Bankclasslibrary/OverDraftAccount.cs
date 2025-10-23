using Bankclasslibrary;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bankclasslibrary
{
    public class OverDraftAccount : Account
    {
        public double OverdraftLimit { get; set; } = -50;

        public OverDraftAccount(string accountHolderName, string sortCode, string cardNumber, double balance = 0)
            : base(accountHolderName, sortCode, cardNumber, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("You must withdraw a positive amount.");
                return;
            }

            if (Balance - amount < OverdraftLimit)
            {
                Console.WriteLine($"You can't go below your overdraft limit of {OverdraftLimit}.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"You withdrew {amount}. New balance is {Balance}.");
        }

        public override string ToString()
        {
            return $"Overdraft Account for {AccountHolderName} — Balance: {Balance}, Limit: {OverdraftLimit}";
        }
    }
}