using System;

public class RecordMain
{
    static void Main(string[] args)
    {
        //Taking user input
        Console.WriteLine("Enter employee ID:");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter department:");
        string dept = Console.ReadLine();
        Console.WriteLine("Enter salary:");
        double salary = Convert.ToDouble(Console.ReadLine());


        Manager manager = new Manager(id, dept, salary);
        manager.DisplayManagerDetails();


        Console.WriteLine("Current Salary: " + manager.GetSalary());
        Console.WriteLine("Enter new salary:");
        double newSalary = Convert.ToDouble(Console.ReadLine());


        manager.SetSalary(newSalary);
        Console.WriteLine("Updated Salary: " + manager.GetSalary());
    }
}
