using System;

namespace Employee
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private Employee[] employees = new Employee[10];
        private int count = 0;
        private Random random = new Random();

        private const int wage_per_hour = 20;
        private const int full_day_hours = 8;

        public void AddEmployee()
        {
            Employee employee = new Employee();

            Console.WriteLine("Enter Employee ID:");
            employee.EmployeeId = Console.ReadLine();
            Console.WriteLine("Enter Employee Name:");
            employee.EmployeeName = Console.ReadLine();

            employees[count] = employee;
            count++;

            Console.WriteLine("Employee Added Successfully");

        }


        // UC1: Check Employee is Present or Absent using RANDOM
        public void AttendanceCheck()
        {
            for (int i = 0; i < count; i++)
            {
                int isPresent = random.Next(0, 2);

                if (isPresent == 1)
                {
                    employees[i].EmployeeAttendance = "Present";
                }
                else
                {
                    employees[i].EmployeeAttendance = "Absent";
                }
            }


        }


        // UC2 Calculate Daily Wage
        public void CalculateDailyWage()
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeAttendance == "Present")
                {
                    employees[i].DailyWage = wage_per_hour * full_day_hours;
                }
                else
                {
                    employees[i].DailyWage = 0;
                }
            }
           
        }


        public void DisplayEmployee()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(employees[i]);

            }
        }
    }
}
