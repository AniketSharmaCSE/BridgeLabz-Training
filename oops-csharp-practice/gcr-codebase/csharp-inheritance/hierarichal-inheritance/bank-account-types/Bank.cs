using System;

class Bank
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter account number:");
        int accountNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter balance:");
        double balance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select account type:");
        Console.WriteLine("1.Savings");
        Console.WriteLine("2.Checking");
        Console.WriteLine("3.Fixed Deposit");

        int choice = Convert.ToInt32(Console.ReadLine());

        BankAccount account;

        if (choice == 1)
        {
            Console.WriteLine("Enter interest rate:");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            account = new SavingsAccount(accountNumber, balance, interestRate);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter withdrawal limit:");
            double withdrawalLimit = Convert.ToDouble(Console.ReadLine());

            account = new CheckingAccount(accountNumber, balance, withdrawalLimit);
        }
        else
        {
            Console.WriteLine("Enter lock-in period in months:");
            int lockInPeriod = Convert.ToInt32(Console.ReadLine());

            account = new FixedDepositAccount(accountNumber, balance, lockInPeriod);
        }

        account.DisplayAccountType();
    }
}
