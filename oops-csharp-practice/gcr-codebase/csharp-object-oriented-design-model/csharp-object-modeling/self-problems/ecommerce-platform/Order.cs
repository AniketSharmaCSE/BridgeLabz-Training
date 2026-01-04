using System;

class Order
{
    public int OrderId;
    public Product[] Products;

    public Order(int id, int productCount)
    {
        OrderId = id;
        Products = new Product[productCount];
    }

    public void Display()
    {
        Console.WriteLine("Order ID: " + OrderId);
        for (int i = 0; i < Products.Length; i++)
        {
            Console.WriteLine("Product: " + Products[i].Name);
        }
    }
}
