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

        private const int part_time_hours = 4;


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


        // UC1: Check Employee is Present or Absent using RANDOM(changed for uc2)
        // UC3: Employee Type Check using RANDOM
        public void AttendanceCheck()
        {
            for (int i = 0; i < count; i++)
            {
                int empCheck = random.Next(0, 3);

                if (empCheck == 0)
                {
                    employees[i].EmployeeAttendance = "Absent";
                    employees[i].EmployeeType = "Absent";
                }
                else if (empCheck == 1)
                {
                    employees[i].EmployeeAttendance = "Present";
                    employees[i].EmployeeType = "Full Time";
                }
                else
                {
                    employees[i].EmployeeAttendance = "Present";
                    employees[i].EmployeeType = "Part Time";
                }
            }
        }



        // UC2 Calculate Daily Wage
        // UC3 Calculate Daily Wage based on Employee Type
        public void CalculateDailyWage()
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeType == "Full Time")
                {
                    employees[i].DailyWage = wage_per_hour * full_day_hours;
                }
                else if (employees[i].EmployeeType == "Part Time")
                {
                    employees[i].DailyWage = wage_per_hour * PART_TIME_HOURS;
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
