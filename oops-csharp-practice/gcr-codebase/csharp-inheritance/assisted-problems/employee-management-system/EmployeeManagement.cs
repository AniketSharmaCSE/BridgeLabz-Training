using System;

class EmployeeManagement
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select employee type:");
        Console.WriteLine("1.Manager");
        Console.WriteLine("2.Developer");
        Console.WriteLine("3.Intern");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter id:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter salary:");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee employee;

        if (choice == 1)
        {
            Console.WriteLine("Enter team size:");
            int teamSize = Convert.ToInt32(Console.ReadLine());

            employee = new Manager(name, id, salary, teamSize);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter programming language:");
            string language = Console.ReadLine();

            employee = new Developer(name, id, salary, language);
        }
        else
        {
            Console.WriteLine("Enter internship duration:");
            string duration = Console.ReadLine();

            employee = new Intern(name, id, salary, duration);
        }

        Console.WriteLine("Employee Details:");
        employee.DisplayDetails();
    }
}
