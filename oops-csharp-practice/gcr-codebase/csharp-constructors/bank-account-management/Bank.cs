using System;

public class Bank
{
    static void Main(string[] args)
    {
        //Taking user input
        Console.WriteLine("Enter account number:");
        int accNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter account holder name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter balance:");
        double balance = Convert.ToDouble(Console.ReadLine());


        SavingsAccount account = new SavingsAccount(accNo, name, balance);
        account.DisplayAccountInfo();

        Console.WriteLine("Current Balance: " + account.GetBalance());
        Console.WriteLine("Enter new balance:");
        double newBalance = Convert.ToDouble(Console.ReadLine());


        account.SetBalance(newBalance);
        Console.WriteLine("Updated Balance: " + account.GetBalance());
    }

}
