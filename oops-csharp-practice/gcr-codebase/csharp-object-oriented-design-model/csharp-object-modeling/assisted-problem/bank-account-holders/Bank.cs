using System;

public class Bank
{
    string bankName;
    Customer[] customers;
    int index = 0;
	

    //Bank created with fixed customer capacity
    public Bank(string bankName, int size){
        this.bankName = bankName;
        customers = new Customer[size];
    }


    //Associates customer with bank
    public void OpenAccount(Customer customer)
    {
        if (index < customers.Length)
        {
            customers[index] = customer;
            index++;

            Console.WriteLine("Account opened in " + bankName);

        }
    }


    //Displays all associated customers
    public void DisplayCustomers()
    {
        Console.WriteLine("Bank: " + bankName);

        for (int i = 0; i < index; i++)
        {
            customers[i].DisplayCustomer();
        }

    }
}
