using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OCP
{
    public abstract class BankAccount
    {
        public decimal Balance { get; protected set; }

        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);
    }

}
