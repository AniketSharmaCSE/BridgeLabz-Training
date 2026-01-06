using System;

public class Bird
{
    protected string name;

    
    public Bird(string name)
    {
        this.name = name;
    }


    public void DisplayBird(){
        Console.WriteLine("Bird Name: " + name);
    }

}
