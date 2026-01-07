using System;

public abstract class BankAccount
{
    private string accountNumber;
    private string accountHolderName;
    protected double balance;

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string AccountHolderName
    {
        get { return accountHolderName; }
        set { accountHolderName = value; }
    }

    public void Deposit(double amount)
    {
        //add deposited amount to balance
        balance = balance + amount;
    }

    public void Withdraw(double amount)
    {
        //check balance before withdrawal
        if (amount <= balance)
        {
            balance = balance - amount;
        }
    }

    public abstract double CalculateInterest();
}
