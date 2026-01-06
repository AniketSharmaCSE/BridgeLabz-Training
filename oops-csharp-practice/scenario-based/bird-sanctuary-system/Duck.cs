using System;

public class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name)
    {
    }

    public void Swim()
    {
        Console.WriteLine("Duck swims on water");
    }
}
