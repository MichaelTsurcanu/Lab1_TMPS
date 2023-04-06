using ConsoleApp1.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BankTransactionManager1
{
    // Single Responsibility Principle (SRP)
    // This class is responsible for managing the bank's transactions
    public class BankTransactionManager
    {
        public void Deposit(BankAccount account, decimal amount)
        {
            account.Deposit(amount);
        }

        public void Withdraw(BankAccount account, decimal amount)
        {
            account.Withdraw(amount);
        }

        public void Transfer(BankAccount fromAccount, BankAccount toAccount, decimal amount)
        {
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
        }
    }
}
