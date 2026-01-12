using System;

public class Rod
{
    public int Length { get; private set; }
    public int[] Prices { get; private set; }

    public Rod(int length, int[] prices)
    {
        this.Length = length;
        this.Prices = prices;
    }

    //UC2: Method to update price for custom-length order
    public void UpdatePrice(int length, int newPrice)
    {
        if (length <= 0 || length > Length)
        {
            Console.WriteLine("Invalid rod length for price update.");
            return;
        }

        Prices[length] = newPrice;
    }

}
