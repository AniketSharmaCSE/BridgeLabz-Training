using System;

public class Groceries : Product
{
    public Groceries(double price)
    {
        this.price = price;
    }

    public override double CalculateDiscount()
    {
        return price * 0.05;
    }
}
