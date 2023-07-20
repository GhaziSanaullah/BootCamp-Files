using System;
using System.Collections.Generic;

namespace BankAccount_v5
{
    // This class represents a loan account and inherits from the BankAccount class
    public class LoanAccount : BankAccount
    {
        // Constructor to initialize the loan account with account number, account holder name, and balance
        public LoanAccount(string accountNumber, string accountHolderName, decimal balance)
            : base(accountNumber, accountHolderName, balance)
        {
        }

        // Override the Deposit method to disallow deposits for a loan account
        public override void Deposit(decimal amount)
        {
            Console.WriteLine("Deposits are not allowed for a loan account.");
        }
    }
}