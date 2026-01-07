using System;

class EmployeeManagement
{
    static void Main()
    {
        Employee[] employeeList = new Employee[2];

        Console.WriteLine("Enter Full Time Employee Details");

        Console.Write("Employee Id: ");
        int fullTimeEmployeeId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Employee Name: ");
        string fullTimeEmployeeName = Console.ReadLine();
        Console.Write("Monthly Salary: ");
        double fullTimeSalary = Convert.ToDouble(Console.ReadLine());


        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(fullTimeSalary);
        fullTimeEmployee.EmployeeId = fullTimeEmployeeId;
        fullTimeEmployee.EmployeeName = fullTimeEmployeeName;

        Console.Write("Department Name: ");
        fullTimeEmployee.AssignDepartment(Console.ReadLine());

        employeeList[0] = fullTimeEmployee;

        Console.WriteLine("\nEnter Part Time Employee Details");
        Console.Write("Employee Id: ");
        int partTimeEmployeeId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Employee Name: ");
        string partTimeEmployeeName = Console.ReadLine();
        Console.Write("Total Working Hours: ");
        int totalWorkingHours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Wage Per Hour: ");
        int wagePerHour = Convert.ToInt32(Console.ReadLine());


        PartTimeEmployee partTimeEmployee =
            new PartTimeEmployee(totalWorkingHours, wagePerHour);

        partTimeEmployee.EmployeeId = partTimeEmployeeId;
        partTimeEmployee.EmployeeName = partTimeEmployeeName;

        employeeList[1] = partTimeEmployee;

        Console.WriteLine("\nEmployee Details");

        for (int index = 0; index < employeeList.Length; index++)
        {
            employeeList[index].DisplayDetails();
            Console.WriteLine();

        }

    }
}
