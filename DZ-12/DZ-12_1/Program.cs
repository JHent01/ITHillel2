using DZ_12_1;

class Program
{
    static void Main(string[] args)
    {
        BankAccount bankSavingsAccount = new SavingsAccount("Me", 5000, 0.05);

        bankSavingsAccount.DisplayAccountInfo();
        Console.WriteLine();
        bankSavingsAccount.Withdraw(1000);
        bankSavingsAccount.DisplayAccountInfo();
        Console.WriteLine();
        bankSavingsAccount.Deposit(8000);
        bankSavingsAccount.DisplayAccountInfo();
        Console.WriteLine();

        BankAccount bankChecking = new CheckingAccount("Tom",5000,1000);
        bankChecking.DisplayAccountInfo();
        Console.WriteLine();
        bankChecking.Withdraw(5000);
        bankChecking.DisplayAccountInfo();
        Console.WriteLine();
        bankChecking.Deposit(2000);
        Console.WriteLine();
        bankChecking.DisplayAccountInfo();
        Console.WriteLine();
        bankChecking.Withdraw(2100);
        bankChecking.DisplayAccountInfo();
        Console.WriteLine();


        BankAccount bankSavingsAccount_2 = new SavingsAccount("You", 8000, 0.05);
        bankSavingsAccount_2.DisplayAccountInfo();
    }
}