public class Wood
{
    public int WoodLength { get; private set; }
    public int[] Prices { get; private set; }

    public Wood(int woodLength, int[] prices)
    {
        this.WoodLength = woodLength;
        this.Prices = prices;
    }
}
