using System;

public abstract class Product
{
    private int productId;
    private string productName;
    protected double price;

    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }

    public abstract double CalculateDiscount();
}
