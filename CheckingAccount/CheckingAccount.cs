using ConsoleApp1.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CheckingAccount
{
    // Liskov Substitution Principle (LSP)
    
    public class CheckingAccount : BankAccount
    {
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
