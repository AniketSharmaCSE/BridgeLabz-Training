using System;

public class Employee
{
	
    public static string CompanyName = "Tech Solutions";
    static int totalEmployees = 0;
    string name;
    readonly int id;
    string designation;


    //Constructor assigns values using this keyword
    public Employee(string name, int id, string designation)
    {
        this.name = name;
        this.id = id;
        this.designation = designation;
        totalEmployees++;
    }


    //Prints employee information
    public void ShowEmployee(){
		
        Console.WriteLine("Company: " + CompanyName);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Designation: " + designation);
    
	}


    //Displays total employee count
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    
	}

}
