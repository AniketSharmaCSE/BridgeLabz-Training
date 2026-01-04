using System;

public class AnimalMain
{
    static void Main(string[] args)
    {
        //Taking user input
        Console.WriteLine("Enter animal type:");
        string type = Console.ReadLine().ToLower();
        Console.WriteLine("Enter animal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter animal age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Animal animal;
        //Creating object based on user choice
        if (type == "dog")
        {
            animal = new Dog(name, age);
        }
        else if (type == "cat")
        {
            animal = new Cat(name, age);
        }
        else if (type == "bird")
        {
            animal = new Bird(name, age);
        }
        else
        {
            animal = new Animal(name, age);
        }
		
        animal.MakeSound();
    }
}
