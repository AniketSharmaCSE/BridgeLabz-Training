using System;

public class Manager : Employee
{
    //Constructor calling base class constructor
    public Manager(int employeeID, string department, double salary): base(employeeID, department, salary)
    {
		
    }


    //Method to access public and protected members
    public void DisplayManagerDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
    }
}
