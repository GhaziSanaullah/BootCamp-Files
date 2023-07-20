using System;
using System.Collections.Generic;

namespace BankAccount_v5
{
    // This class represents a bank
    public class Bank
    {
        // Private dictionary to store accounts with their account numbers as keys
        private Dictionary<string, BankAccount> Accounts { get; set; }

        // Constructor to initialize the bank with an empty dictionary of accounts
        public Bank()
        {
            Accounts = new Dictionary<string, BankAccount>();
        }

        // Method to add an account to the bank's dictionary of accounts
        public void AddAccount(BankAccount account)
        {
            Accounts.Add(account.GetAccountNumber(), account);
        }

        // Method to remove an account from the bank's dictionary of accounts
        public void RemoveAccount(string accountNumber)
        {
            if (Accounts.ContainsKey(accountNumber))
            {
                Accounts.Remove(accountNumber);
                Console.WriteLine("Account Removed from account dictionary.");
            }
            else
            {
                Console.WriteLine("Account to remove not found.");
            }
        }

        // Method to retrieve an account from the bank's dictionary of accounts based on the account number
        public BankAccount GetAccount(string accountNumber)
        {
            if (Accounts.ContainsKey(accountNumber))
            {
                return Accounts[accountNumber];
            }
            else
            {
                return null;
            }
        }
    }
}
