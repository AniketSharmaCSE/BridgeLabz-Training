using System;

namespace Employee
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeService;

        public void Menu()
        {
            employeeService = new EmployeeUtilityImpl();

            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Attendance Check");
                Console.WriteLine("3. Display Employee");
                Console.WriteLine("4. Exit");

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
                        employeeService.DisplayEmployee();
                        break;

                    case 4:
                        return;
                
                }
            }
       
        }
    }
}
