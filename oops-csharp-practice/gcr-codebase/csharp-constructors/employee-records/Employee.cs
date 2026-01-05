using System;

public class Employee
{
	
    public int employeeID;
    protected string department;
    private double salary;

    //Constructor to initialize employee details
    public Employee(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }


    //Public method to get salary
    public double GetSalary()
    {
        return salary;
    }


    //Public method to update salary
    public void SetSalary(double salary){
        this.salary = salary;
    
	}

}
