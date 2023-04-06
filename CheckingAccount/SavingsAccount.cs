using ConsoleApp1.Interfaces;
using ConsoleApp1.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CheckingAccount
{

    // This class implements the BankAccount and IInterestAccrual interfaces, and represents a savings account
    public class SavingsAccount : BankAccount, IInterestAccrual
    {
        public decimal InterestRate { get; set; }

        public void AccrueInterest()
        {
            decimal interest = Balance * InterestRate;
            Deposit(interest);
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            Balance -= amount;
        }
    }
}
