using System;
using System.Collections.Generic;

namespace BankAccount_v5
{
    // This is an abstract class representing a bank account and implementing the ITransaction interface
    public abstract class BankAccount : ITransaction
    {
        // Protected properties to store account information
        protected string AccountNumber { get; set; }
        protected string AccountHolderName { get; set; }
        protected decimal Balance { get; set; }
        protected List<Transaction> Transactions { get; set; }

        // Constructor to initialize the account with account number, account holder name, and initial balance
        public BankAccount(string accountNumber, string accountHolderName, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
            Transactions = new List<Transaction>();
        }

        // Virtual method to deposit the specified amount into the account
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Transactions.Add(new Transaction("Deposit", amount));
        }

        // Virtual method to withdraw the specified amount from the account
        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
            Transactions.Add(new Transaction("Withdrawal", amount));
        }

        // Virtual method to calculate interest (to be overridden by subclasses if necessary)
        public virtual void CalculateInterest()
        { }


        // Implementation of the ExecuteTransaction method from the ITransaction interface
        public void ExecuteTransaction(decimal amount)
        { }

        // Implementation of the PrintTransaction method from the ITransaction interface
        public void PrintTransaction()
        { }

        // Virtual method to display account information, including balance and transaction history
        public virtual void DisplayAccountInfo(Bank bank)
        {
            // Check if the account is still available in the bank
            if (bank.GetAccount(AccountNumber) == null)
            {
                Console.WriteLine("The account you requested information on does not exist.");
            }
            else
            {
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Account Holder's Name: " + AccountHolderName);
                Console.WriteLine("Balance: " + Balance);
                Console.WriteLine("Transaction History: ");
                foreach (Transaction transaction in Transactions)
                {
                    Console.WriteLine(transaction.ToString());
                }
            }
        }

        // Method to retrieve the account number
        public string GetAccountNumber()
        {
            return AccountNumber;
        }
    }
}