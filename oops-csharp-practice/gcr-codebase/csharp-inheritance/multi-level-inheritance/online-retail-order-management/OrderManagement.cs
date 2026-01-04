using System;

class OrderManagement
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter order id:");
        int orderId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter order date:");
        string orderDate = Console.ReadLine();
        Console.WriteLine("Enter tracking number:");
        string trackingNumber = Console.ReadLine();
        Console.WriteLine("Enter delivery date:");
        string deliveryDate = Console.ReadLine();

        Order order = new DeliveredOrder(orderId, orderDate, trackingNumber, deliveryDate);

        Console.WriteLine("Order Status:");
        Console.WriteLine(order.GetOrderStatus());
    }
}
