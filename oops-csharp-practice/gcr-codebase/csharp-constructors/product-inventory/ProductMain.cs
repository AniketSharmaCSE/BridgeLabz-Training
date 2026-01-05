using System;

public class ProductMain
{
    static void Main(string[] args)
    {
		
        Console.WriteLine("Enter number of products:");
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            //Taking user input for each product
            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Product product = new Product(name, price);
            product.DisplayProductDetails();
        }


        //Calling class method using class name
        Product.DisplayTotalProducts();
    }
}
