using System;

public class Person
{
	
    string name;
    int age;

    //Parameterized constructor
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }


    //Copy constructor
    public Person(Person p)
    {
        this.name = p.name;
        this.age = p.age;
    }


    //display person details
    public void DisplayDetails()
    {
        Console.WriteLine(name + " " + age);
    }
}
