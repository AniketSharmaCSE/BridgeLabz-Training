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

        private const int working_days = 20;

        private const int max_working_days = 20;
        private const int max_working_hours = 100;




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

        //UC5:Calculate Monthly Wage (20 Working Days)
        public void CalculateMonthlyWage()
    {
    for (int i = 0; i < count; i++)
    {
        int totalWage = 0;

        for (int day = 1; day <= working_days; day++)
        {
            totalWage = totalWage + employees[i].DailyWage;
        }

        employees[i].MonthlyWage = totalWage;
    }

    Console.WriteLine("Monthly Wage Calculated Successfully");
}

        //UC6: Calculate Wage till total working hours or days reached
public void CalculateWageTillCondition()
{
    for (int i = 0; i < count; i++)
    {
        int totalHours = 0;
        int totalDays = 0;
        int totalWage = 0;

        while (totalDays < max_working_days && totalHours < max_working_hours)
        {
            int empCheck = random.Next(0, 3);
            int hoursWorked = 0;

            switch (empCheck)
            {
                case 1: // Full Time
                    hoursWorked = full_day_hours;
                    break;

                case 2: // Part Time
                    hoursWorked = part_time_hours;
                    break;

                default: // Absent
                    hoursWorked = 0;
                    break;
            }

            totalHours = totalHours + hoursWorked;
            totalWage = totalWage + (hoursWorked * wage_per_hour);
            totalDays++;
        }

        employees[i].TotalWorkingHours = totalHours;
        employees[i].MonthlyWage = totalWage;
    }

    Console.WriteLine("Wage Calculated Till Condition Reached");
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
