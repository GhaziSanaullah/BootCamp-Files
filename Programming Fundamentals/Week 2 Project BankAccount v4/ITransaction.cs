using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_v5
{
    // This interface defines the contract for executing and printing transactions
    public interface ITransaction
    {
        // This method is responsible for executing a transaction with the specified amount
        void ExecuteTransaction(decimal amount);

        // This method is responsible for printing the details of a transaction
        void PrintTransaction();
    }
}