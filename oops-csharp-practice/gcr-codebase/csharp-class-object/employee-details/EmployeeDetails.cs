using System;

public class EmployeeDetails
{
    static void Main(string[] args)
    {
        // Taking input from user before creating object
        Console.WriteLine("Enter employee name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter employee id:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter employee salary:");
        double salary = Convert.ToDouble(Console.ReadLine());

        // Creating object using constructor
        Employee emp = new Employee(name, id, salary);

        Console.WriteLine();
        emp.DisplayDetails();
    }
}
