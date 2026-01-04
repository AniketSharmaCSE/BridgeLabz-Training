using System;

public class BankAccount
{
	
    //Static variable shared across all accounts
    public static string bankName = "State Bank";
    //Static variable to count total accounts
    static int totalAccounts = 0;


    string accountHolderName;
    readonly int accountNumber;
    double balance;

    //Constructor using this keyword and readonly variable
    public BankAccount(string accountHolderName, int accountNumber, double balance)
    {
        this.accountHolderName = accountHolderName;
        this.accountNumber = accountNumber;
        this.balance = balance;
        //Increment account count when object is created
        totalAccounts++;
    }

    //Method to display account details
    public void DisplayDetails()
    {
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("Account Holder: " + accountHolderName);
       
	   Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance);
    }

    //Static method to display total accounts
    public static void GetTotalAccounts(){
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }
}
