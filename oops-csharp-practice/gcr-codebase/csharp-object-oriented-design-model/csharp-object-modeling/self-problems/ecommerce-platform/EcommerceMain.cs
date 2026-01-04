using System;

class EcommerceMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter customer name:");
        Customer customer = new Customer(Console.ReadLine());
        Console.WriteLine("Enter order id:");
        int orderId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of products:");
        int count = Convert.ToInt32(Console.ReadLine());

        Order order = new Order(orderId, count);

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter product name:");
            order.Products[i] = new Product(Console.ReadLine());
        }

        customer.PlaceOrder(order);
    }
}
