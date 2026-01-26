using System;

public class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Patient(string name, int age) {
        Name = name;
        Age = age;
    }
    public virtual void DisplayInfo() {
        Console.WriteLine("Patient name: " + Name);
        Console.WriteLine("Patient age: " + Age);
    }


}
