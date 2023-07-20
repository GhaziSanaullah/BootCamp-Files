using System;
using System.Collections.Generic;
namespace BankAccount_v5
{
    // This class represents a checking account and inherits from the BankAccount class
    class CheckingAccount : BankAccount
    {
        // Constructor to initialize the checking account with account number, account holder name, and balance
        public CheckingAccount(string accountNumber, string accountHolderName, decimal balance)
            : base(accountNumber, accountHolderName, balance)
        {
        }

        // Override the Deposit method to deposit the specified amount into the account
        public override void Deposit(decimal amount)
        {
            base.Deposit(amount);
            Console.WriteLine("The " + amount + " has been depsited. New Balance is " + Balance);
        }

        // Additional Deposit method that converts USD to the account's currency and then deposits
        public void Deposit(string currency, decimal amount)
        {
            if (currency.ToUpper() == "USD")
            {
                // Convert USD to the account's currency and then deposit
                decimal convertedAmount = ConvertToAccountCurrency("USD", amount);
                base.Deposit(convertedAmount);
            }
            else
            {
                Console.WriteLine("Deposit currency is not valid.");
            }
        }

        // Override the Withdraw method to withdraw the specified amount from the account
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance. Cannot withdraw.");
            }
            else
            {
                base.Withdraw(amount);
                Console.WriteLine("The " + amount + " has been withdrawn. New Balance is " + Balance);
            }
        }

        // Additional Withdraw method that converts USD to the account's currency and then withdraws
        public void Withdraw(string currency, decimal amount)
        {
            if (currency.ToUpper() == "USD")
            {
                // Convert USD to the account's currency and then withdraw
                decimal convertedAmount = ConvertToAccountCurrency("USD", amount);
                if (convertedAmount <= Balance)
                {
                    base.Withdraw(convertedAmount);
                }
                else
                {
                    Console.WriteLine("Insufficient balance. Cannot withdraw.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal currency is not valid.");
            }
        }

        // Private method to convert an amount from a specified currency to the account's currency
        private decimal ConvertToAccountCurrency(string fromCurrency, decimal amount)
        {
            decimal convertedAmount = amount * 286; // Assuming 1USD = 286PKR 
            return convertedAmount;
        }
    }
}
