using System;

public class Product
{
    string productName;
    double price;

    //static variable 
    static int totalProducts = 0;

    //Constructor to initialize product details
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }
	

    //method to display product details
    public void DisplayProductDetails(){
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: " + price);
    }

    //method to display total products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: " + totalProducts);
    }
}
