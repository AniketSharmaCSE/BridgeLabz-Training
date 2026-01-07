using System;

public class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(double price, int quantity)
    {
        this.price = price;
        this.quantity = quantity;
    }

    public override double CalculateTotalPrice()
    {
        //extra charge for non veg
        return (price * quantity) + 50;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.05;
    }

    public string GetDiscountDetails()
    {
        return "5% Non-Veg Discount";
    }
}
