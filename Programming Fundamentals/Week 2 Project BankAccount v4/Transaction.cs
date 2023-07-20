using System;
using System.Collections.Generic;

namespace BankAccount_v5
{
    // This class represents a transaction made in a bank account
    public class Transaction
    {
        // Properties to store the transaction type and amount
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }

        // Constructor to initialize the transaction with a transaction type and amount
        public Transaction(string transactionType, decimal amount)
        {
            TransactionType = transactionType;
            Amount = amount;
        }

        // Override the ToString method to provide a formatted string representation of the transaction
        public override string ToString()
        {
            return "Transaction Type: " + TransactionType + ", Amount: " + Amount;
        }
    }
}
