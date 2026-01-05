using System;

public class BankAccount
{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    //Constructor to initialize account details
    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
	
	

    //Public method to get balance
    public double GetBalance()
    {
        return balance;
    }


    //Public method to update balance
    public void SetBalance(double balance)
    {
        this.balance = balance;
    }
}
