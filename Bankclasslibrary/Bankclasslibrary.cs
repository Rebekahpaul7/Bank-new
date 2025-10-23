using System;

namespace Bankclasslibrary
{
    public class Account
    {
        public string AccountHolderName { get; set; }
        public string SortCode { get; set; }
        public string CardNumber { get; set; }
        public double Balance { get; protected set; }

        public Account(string accountHolderName = "Unknown", string sortCode = "00-00-00", string cardNumber = "0000 0000 0000 0000", double balance = 0)
        {
            AccountHolderName = accountHolderName;
            SortCode = sortCode;
            CardNumber = cardNumber;
            Balance = balance;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Details");
            Console.WriteLine($"Account Holder Name: {AccountHolderName}");
            Console.WriteLine($"Sort Code: {SortCode}");
            Console.WriteLine($"Card Number: {CardNumber}");
            Console.WriteLine($"Balance: {Balance}");
        }

        public virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds!");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");
            }
        }

        public override string ToString()
        {
            return $"Account Holder: {AccountHolderName}, Sort Code: {SortCode}, Card Number: {CardNumber}, Balance: {Balance}";
        }
    }
}
