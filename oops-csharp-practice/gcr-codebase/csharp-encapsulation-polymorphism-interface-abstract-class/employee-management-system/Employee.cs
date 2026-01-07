using System;

public abstract class Employee
{
    private int employeeId;
    private string name;
    protected double baseSalary;

    public int EmployeeId
    {
        get 
        { 
            return employeeId;             
        }
        
        set 
        { 
            employeeId = value;
        }
    
    }

    public string Name
    {
        get 
        {
             return name; 
        }
        set 
        {
             name = value; 
        }
    
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine("Id: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + CalculateSalary());
    }
}
