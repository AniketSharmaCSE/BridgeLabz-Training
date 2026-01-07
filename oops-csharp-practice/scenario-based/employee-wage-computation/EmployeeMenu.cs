using System;

namespace Employee
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeService;

        public void Menu()
        {
            employeeService = new EmployeeUtilityImpl();
            //UC4: Employee Menu Driven Program
            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Attendance Check ");
                Console.WriteLine("3. Calculate Daily Wage using Switch Case ");
                Console.WriteLine("4. Display Employee");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employeeService.AddEmployee();
                        break;

                    case 2:
                        employeeService.AttendanceCheck();
                        break;

                    case 3:
                        employeeService.CalculateDailyWage();
                        break;

                    case 4:
                        employeeService.DisplayEmployee();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
