using System;

class BankAccount
{
    public int AccountNumber;
    public double Balance;

    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    //Method to display basic account details
    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Generic Bank Account");
    }
}
