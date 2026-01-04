using System;

public class Animal
{
    protected string name;
    protected int age;

    //Constructor to initialize animal details
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    //method to make sound
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
