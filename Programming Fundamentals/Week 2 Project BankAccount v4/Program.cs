using System;
using System.Collections.Generic;

namespace BankAccount_v5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Bank class
            Bank bank = new Bank();

            // Create a SavingsAccount object
            SavingsAccount savingsAccount = new SavingsAccount("1001", "Jan", 50, 5);

            // Create a CheckingAccount object
            CheckingAccount checkingAccount = new CheckingAccount("2001", "Feb", 100);

            // Create a LoanAccount object
            LoanAccount loanAccount = new LoanAccount("3001", "Mar", -500);

            // Add the created accounts to the bank
            bank.AddAccount(savingsAccount);
            Console.WriteLine();
            bank.AddAccount(checkingAccount);
            Console.WriteLine();
            bank.AddAccount(loanAccount);
            Console.WriteLine();
            bank.RemoveAccount("1001");
            Console.WriteLine();

            // Perform transactions on the accounts
            savingsAccount.Deposit(bank ,500);
            Console.WriteLine();
            checkingAccount.Deposit(1000);
            Console.WriteLine();
            checkingAccount.Withdraw(800);
            Console.WriteLine();

            // Display information for each account
            savingsAccount.DisplayAccountInfo(bank);
            Console.WriteLine();
            checkingAccount.DisplayAccountInfo(bank);
            Console.WriteLine();
            loanAccount.DisplayAccountInfo(bank);
            Console.WriteLine();

            // Remove the loan account from the bank
            bank.RemoveAccount("3001");
            Console.WriteLine();

            // Display the loan account information after removal
            loanAccount.DisplayAccountInfo(bank);

            // Wait for user input before exiting the program
            Console.ReadKey();
        }
    }
}
