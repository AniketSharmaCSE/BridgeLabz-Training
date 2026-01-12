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
}
