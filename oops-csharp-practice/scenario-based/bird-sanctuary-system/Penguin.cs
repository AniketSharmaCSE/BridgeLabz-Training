using System;

public class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name)
    {
  
    }

    
    public void Swim()
    {
        Console.WriteLine("Penguin swims underwater");
    }

}


