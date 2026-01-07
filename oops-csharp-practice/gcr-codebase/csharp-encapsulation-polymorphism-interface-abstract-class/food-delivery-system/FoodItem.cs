using System;

public abstract class FoodItem
{
    private string itemName;
    protected double price;
    protected int quantity;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public abstract double CalculateTotalPrice();

    public void GetItemDetails()
    {
        Console.WriteLine("Item Name: " + itemName);
        Console.WriteLine("Total Price: " + CalculateTotalPrice());
    }
}
