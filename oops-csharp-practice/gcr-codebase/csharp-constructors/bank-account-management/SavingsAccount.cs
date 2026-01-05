using System;

public class SavingsAccount : BankAccount
{
    //Constructor calling base class constructor
    public SavingsAccount(int accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance)
    {
		
    }

    
	//Method to access public and protected members
    public void DisplayAccountInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
    }
}
