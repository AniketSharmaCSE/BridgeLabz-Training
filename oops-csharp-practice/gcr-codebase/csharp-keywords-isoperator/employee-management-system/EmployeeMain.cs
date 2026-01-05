using System;

public class EmployeeMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter company name:");
        Employee.CompanyName = Console.ReadLine();
        Console.WriteLine("Enter number of employees:");
        int count = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter employee id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter designation:");
            string designation = Console.ReadLine();

            Employee emp = new Employee(name, id, designation);


            //Ensuring object type before access
            if (emp is Employee)
            {
                emp.ShowEmployee();
            }

        }


        Employee.DisplayTotalEmployees();
    }
}
