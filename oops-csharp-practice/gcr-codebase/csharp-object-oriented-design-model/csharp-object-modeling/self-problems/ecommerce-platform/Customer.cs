using System;

class Customer
{
    public string Name;

    public Customer(string name)
    {
        Name = name;
    }

    public void PlaceOrder(Order order)
    {
        Console.WriteLine(Name + " placed an order");
        order.Display();
    }
}
