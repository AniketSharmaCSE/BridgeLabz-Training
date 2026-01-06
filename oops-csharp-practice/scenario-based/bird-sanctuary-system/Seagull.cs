using System;

public class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name)
    {
   
    }

    
    public void Fly()
    {
        Console.WriteLine("Seagull flies near the sea");
    }

    
    public void Swim()
    {
        Console.WriteLine("Seagull swims on sea");
    }

}


