using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12_1
{
    internal class CheckingAccount : BankAccount
    {
        double overdraftLimit;
        public CheckingAccount(string accountHolder, double balance, double overdraftLimit) : base(accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public override double Deposit(double amount)
        {
            balance = balance +amount;
            return balance;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Balance = {balance}");
            Console.WriteLine($"AccountHolder = {accountHolder}");
            Console.WriteLine($"AccountNumber = {accountNumber}");
            Console.WriteLine($"overdraftLimit = {overdraftLimit}");
        }

        public override double Withdraw(double amount)
        {

            if (amount <= balance)
            {
                balance -= amount;
            }
            else if (amount <= balance+ overdraftLimit)
            {
                balance= balance+overdraftLimit - amount;
                overdraftLimit = 0;
                Console.WriteLine("used overdraftLimit");
            }
            else Console.WriteLine("amount > balance together with overdraftLimit ");
            return balance;
        }
    }
}
