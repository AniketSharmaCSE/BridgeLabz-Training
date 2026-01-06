using System;

public class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name)
    {

    }


    public void Fly()
    {
        Console.WriteLine("Eagle flies at high altitude");
    }

}
