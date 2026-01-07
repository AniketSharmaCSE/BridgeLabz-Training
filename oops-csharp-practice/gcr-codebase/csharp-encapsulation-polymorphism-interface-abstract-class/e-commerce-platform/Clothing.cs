using System;

public class Clothing : Product, ITaxable
{
    public Clothing(double price)
    {
        this.price = price;
    }

    public override double CalculateDiscount()
    {
        return price * 0.20;
    }

    public double CalculateTax()
    {
        return price * 0.12;
    }
}
