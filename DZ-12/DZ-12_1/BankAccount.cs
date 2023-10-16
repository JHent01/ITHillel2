using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12_1
{
    abstract class BankAccount
    {
        public static int accountNumber;
        public string accountHolder;
        public double balance;

        public BankAccount(string accountHolder, double balance)
        {
            this.accountHolder = accountHolder;
            this.balance = balance;
            accountNumber++;
            balance = 0;
        }

        public abstract double Deposit(double amount);
        public abstract double Withdraw(double amount);
        public abstract void DisplayAccountInfo();
    }
}
