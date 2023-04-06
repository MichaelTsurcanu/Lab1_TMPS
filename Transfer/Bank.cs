using ConsoleApp1.BankTransactionManager1;
using ConsoleApp1.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Transfer
{
    // Dependency Inversion Principle (DIP)
    // This class represents the bank itself, and depends on abstractions rather than concrete implementations
    public class Bank
    {
        private readonly BankTransactionManager _transactionManager;

        public Bank(BankTransactionManager transactionManager)
        {
            _transactionManager = transactionManager;
        }

        public void TransferFunds(BankAccount fromAccount, BankAccount toAccount, decimal amount)
        {
            _transactionManager.Transfer(fromAccount, toAccount, amount);
        }
    }
}
