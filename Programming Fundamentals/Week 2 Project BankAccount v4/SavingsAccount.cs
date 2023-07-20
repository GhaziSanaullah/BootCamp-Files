using System;
using System.Collections.Generic;

namespace BankAccount_v5
{
    // This class represents a savings account and inherits from the BankAccount class
    public class SavingsAccount : BankAccount
    {
        // Private property to store the interest rate of the savings account.
        private decimal InterestRate { get; set; }

        // Constructor to initialize the savings account with account number, account holder name, balance, and interest rate
        public SavingsAccount(string accountNumber, string accountHolderName, decimal balance, decimal interestRate)
            : base(accountNumber, accountHolderName, balance)
        {
            InterestRate = interestRate;
        }

        // Override the Deposit method to calculate interest after depositing an amount
        public void Deposit(Bank bank, decimal amount)
        {
            if (bank.GetAccount(AccountNumber) == null)
            {
                Console.WriteLine("The account you requested information on does not exist.");
            }
            else
            {
                base.Deposit(amount);
                Console.Write("The " + amount + " has been depsited");
                CalculateInterest();
            }
        }

        // Override the Withdraw method to disallow withdrawals from a savings account
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("Withdrawal is not allowed from a savings account.");
        }

        // Override the CalculateInterest method to calculate and deposit interest into the account
        public override void CalculateInterest()
        {
            decimal interestAmount = Balance * InterestRate / 100;
            Balance += interestAmount;
            Console.Write(". The new balance is "+ Balance);
            Console.WriteLine();
            Transactions.Add(new Transaction("Interest", interestAmount));
        }
    }
}