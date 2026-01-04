using System;

public class BankAccountMain
{
    static void Main(string[] args)
    {
        //Taking user input
        Console.WriteLine("Enter account holder name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter account number:");
        int accNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter initial balance:");
        double balance = Convert.ToDouble(Console.ReadLine());


        //Creating BankAccount object
        BankAccount account = new BankAccount(name, accNo, balance);

        //Using is operator before displaying details
        if (account is BankAccount){
            account.DisplayDetails();
        }
		
		
        //Calling static method
        BankAccount.GetTotalAccounts();
    }
}
