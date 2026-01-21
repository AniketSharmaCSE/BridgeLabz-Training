using System;
using System.Collections.Generic;

public class CheckoutCounter
{
    private Queue<Customer> queue = new Queue<Customer>();
    private Inventory inventory;

    public CheckoutCounter(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void AddCustomer()
    {
        Console.Write("Customer ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Number of items: ");
        int n = int.Parse(Console.ReadLine());

        string[] items = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Item name: ");
            items[i] = Console.ReadLine();
        }

        queue.Enqueue(new Customer(id, items));
        Console.WriteLine("Customer added to queue");
    }

    public void ProcessCustomer()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("No customers in queue");
            return;
        }

        Customer customer = queue.Dequeue();
        int totalBill = 0;

        Console.WriteLine("\nBilling Details");
        Console.WriteLine("Customer ID: " + customer.GetCustomerId());
        Console.WriteLine("Items Purchased:");

        foreach (string item in customer.GetItems())
        {
            if (inventory.IsItemAvailable(item))
            {
                int price = inventory.GetPrice(item);
                totalBill += price;
                inventory.UpdateStock(item);

                Console.WriteLine("- " + item + " : ₹" + price);
            }
            else
            {
                Console.WriteLine("- " + item + " : Not Available");
            }
        }

        Console.WriteLine("---------------------------");
        Console.WriteLine("Total Bill Amount: ₹" + totalBill);
    }

}
