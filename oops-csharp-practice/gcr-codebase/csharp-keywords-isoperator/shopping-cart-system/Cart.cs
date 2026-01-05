using System;

public class Cart
{
    
	static void Main(string[] args)
    {
        Console.WriteLine("Enter discount percentage:");
        double discount = Convert.ToDouble(Console.ReadLine());
        Product.UpdateDiscount(discount);

        Console.WriteLine("Enter number of items:");
        int count = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product ID:");
            int id = Convert.ToInt32(Console.ReadLine());


            Product item = new Product(name, price, quantity, id);


            //Confirming object type before using it
            if (item is Product)
            {
                item.ShowProductDetails();

            }

        }

    }

}
