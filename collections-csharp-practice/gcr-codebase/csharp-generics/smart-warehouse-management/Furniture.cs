using System;

public class Furniture : WarehouseItem
{
    public Furniture(string name) : base(name)
    {
    }

    public override void Display()
    {
        Console.WriteLine("Furniture Item: " + Name);
    }
}
