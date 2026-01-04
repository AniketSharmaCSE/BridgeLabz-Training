using System;

public class Bird : Animal
{
    //Constructor calling base class constructor
    public Bird(string name, int age) : base(name, age){
    }

    //Overriding MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Bird tweets");
    }
}
