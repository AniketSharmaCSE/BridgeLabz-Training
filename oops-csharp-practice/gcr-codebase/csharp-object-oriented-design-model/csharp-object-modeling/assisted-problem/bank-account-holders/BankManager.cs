using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter bank name:");
        string bankName = Console.ReadLine();

        Console.WriteLine("Enter number of customers:");
        int count = Convert.ToInt32(Console.ReadLine());

        Bank bank = new Bank(bankName, count);

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter customer name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter initial balance:");
            double balance = Convert.ToDouble(Console.ReadLine());

            Customer customer = new Customer(name, balance);

            //Linking customer with bank
            bank.OpenAccount(customer);

            Console.WriteLine("Balance viewed: " + customer.ViewBalance());
        }

        bank.DisplayCustomers();
    }
}
using System;

public class BankManager
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter bank name:");
        string bankName = Console.ReadLine();
        Console.WriteLine("Enter number of customers:");
        int count = Convert.ToInt32(Console.ReadLine());


        Bank bank = new Bank(bankName, count);


        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter customer name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter initial balance:");
            double balance = Convert.ToDouble(Console.ReadLine());


            Customer customer = new Customer(name, balance);

            //Linking customer with bank
            bank.OpenAccount(customer);
            Console.WriteLine("Balance viewed: " + customer.ViewBalance());
        
		}

        bank.DisplayCustomers();
    }
}
