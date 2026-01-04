using System;

class SavingsAccount : BankAccount
{
    public double InterestRate;

    public SavingsAccount(int accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    //Override to specify savings account
    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Savings Account");
        Console.WriteLine("Interest Rate: " + InterestRate);
    }
}
