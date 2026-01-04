using System;

public class Cat : Animal
{
    
	//Constructor calling base class constructor
    public Cat(string name, int age) : base(name, age){
		}

    
	//Overriding MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}
