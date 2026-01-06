using System;

public class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name)
    {
   
    }

    
    public void Fly()
    {
        Console.WriteLine("Sparrow flies short distances");
    }
}
