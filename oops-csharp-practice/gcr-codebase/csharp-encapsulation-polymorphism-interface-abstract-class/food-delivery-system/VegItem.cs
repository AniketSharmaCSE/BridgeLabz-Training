using System;

public class VegItem : FoodItem, IDiscountable
{
    public VegItem(double price, int quantity)
    {
        this.price = price;
        this.quantity = quantity;
    }

    public override double CalculateTotalPrice()
    {
        return price * quantity;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.10;
    }

    public string GetDiscountDetails()
    {
        return "10% Veg Discount";
    }
}
