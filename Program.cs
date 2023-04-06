using ConsoleApp1.BankTransactionManager1;
using ConsoleApp1.CheckingAccount;
using ConsoleApp1.Transfer;
using System;

namespace ConsoleApp12
{
    // SOLID Principles demonstrated in this application:
    // Single Responsibility Principle (SRP)
    // Open-Closed Principle (OCP)
    // Liskov Substitution Principle (LSP)
    // Interface Segregation Principle (ISP)
    // Dependency Inversion Principle (DIP)

    class Program
    {
        static void Main(string[] args)
        {
            // Example usage:
            var transactionManager = new BankTransactionManager();
            var checkingAccount = new CheckingAccount();
            var savingsAccount = new SavingsAccount { InterestRate = 0.05M };
            var bank = new Bank(transactionManager);

            //begin 
            Console.WriteLine($"checkingAccount Balance = {checkingAccount.Balance}");
            Console.WriteLine($"savingsAccount Balance = {savingsAccount.Balance}");
            bank.TransferFunds(checkingAccount, savingsAccount, 100);
            savingsAccount.AccrueInterest();

            Console.WriteLine($"checkingAccount Balance = {checkingAccount.Balance}");
            Console.WriteLine($"savingsAccount Balance = {savingsAccount.Balance}");
        }
    }
}