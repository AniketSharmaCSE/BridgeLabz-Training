using System;

public class Dog : Animal
{
    //Constructor calling base class constructor
    public Dog(string name, int age) : base(name, age){
    }


    //Overriding MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
