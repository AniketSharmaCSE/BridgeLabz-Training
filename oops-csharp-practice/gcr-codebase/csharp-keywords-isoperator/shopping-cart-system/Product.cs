using System;

public class Product
{
    //Discount percentage applied to all products
    public static double Discount = 0;
    string productName;
    double price;
    int quantity;
    readonly int productID;


    //Constructor assigns product data
    public Product(string productName, double price, int quantity, int productID)
    {
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
        this.productID = productID;
    }


    //Displays final product cost after discount
    public void ShowProductDetails()
    {
        double totalAmount = price * quantity;
        double finalAmount = totalAmount - (totalAmount * Discount / 100);

        Console.WriteLine("Product ID: " + productID);
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Amount After Discount: " + finalAmount);

    }


    //Changes discount value for all products
    public static void UpdateDiscount(double discount)
    {
        Discount = discount;
    
	}
}
