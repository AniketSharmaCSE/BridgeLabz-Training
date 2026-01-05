using System;

public class Customer
{
    string name;
    double balance;


    //Customer initialized with basic details
    public Customer(string name, double balance)
    {
        this.name = name;
        this.balance = balance;
    }


    //Returns current balance
    public double ViewBalance()
    {
        return balance;
    }


    //Displays customer information
    public void DisplayCustomer()
    {
        Console.WriteLine("Customer Name: " + name);
        Console.WriteLine("Balance: " + balance);
    }

}