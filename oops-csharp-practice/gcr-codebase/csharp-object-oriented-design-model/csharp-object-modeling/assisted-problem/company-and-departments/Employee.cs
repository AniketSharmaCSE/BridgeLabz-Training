using System;

public class Employee
{
    string name;
    string role;


    //Employee created only through Department
    public Employee(string name, string role)
    {
        this.name = name;
        this.role = role;
    }


    //Displays employee details
    public void DisplayEmployee()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Role: " + role);
    }
}
