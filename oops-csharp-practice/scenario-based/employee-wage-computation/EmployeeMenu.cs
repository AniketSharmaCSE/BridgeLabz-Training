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
                Console.WriteLine("3. Calculate Daily Wage ");
                Console.WriteLine("4. Calculate Monthly Wage ");
                Console.WriteLine("5. Display Employee");
                Console.WriteLine("6. Exit");

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
                        employeeService.CalculateMonthlyWage();
                        break;

                    case 5:
                        employeeService.DisplayEmployee();
                        break;

                    case 6:
                        return; 
                }
            }
        }
    }
}
