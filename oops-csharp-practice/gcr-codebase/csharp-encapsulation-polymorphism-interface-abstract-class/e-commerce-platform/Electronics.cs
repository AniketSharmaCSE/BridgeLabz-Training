using System;

public class Electronics : Product, ITaxable
{
    public Electronics(double price)
    {
        this.price = price;
    }

    public override double CalculateDiscount()
    {
        return price * 0.10;
    }

    public double CalculateTax()
    {
        return price * 0.18;
    }
}
