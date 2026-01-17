using System;

public class Product
{
    private string name;
    private double price;
    private double discountPercent;

    public Product(string name, double price)
    {
        if (price < 0)
        {
            price = 0;
        }

        this.name = name;
        this.price = price;
        this.discountPercent = 0;
    }

    public void ApplyDiscount(double percent)
    {
        if (percent < 0)
        {
            percent = 0;
        }

        if (percent > 90)
        {
            percent = 90;
        }

        this.discountPercent = percent;
    }

    public string GetName()
    {
        return name;
    }

    public double GetPrice()
    {
        return price;
    }

    public double GetDiscountPercent()
    {
        return discountPercent;
    }

    public double GetDiscountedPrice()
    {
        return price - (price * discountPercent / 100);
    }
}
