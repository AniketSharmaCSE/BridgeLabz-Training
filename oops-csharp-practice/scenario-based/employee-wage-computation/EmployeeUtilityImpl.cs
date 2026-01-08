using System;

namespace Employee
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private Employee[] employees = new Employee[10];
        private int count = 0;
        private Random random = new Random();

        private const int WagePerHour = 20;
        private const int FullDayHours = 8;

        private const int PartTimeHours = 4;

        private const int WorkingDays = 20;

        private const int MaxWorkingDays = 20;
        private const int MaxWorkingHours = 100;




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
                Console.WriteLine(employees[i].EmployeeName + " is " + employees[i].EmployeeAttendance + " (" + employees[i].EmployeeType + ")");
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
                    employees[i].DailyWage = WagePerHour * FullDayHours;
                }
                else if (employees[i].EmployeeType == "Part Time")
                {
                    employees[i].DailyWage = WagePerHour * PartTimeHours;
                }
                else
                {
                    employees[i].DailyWage = 0;
                }
                Console.WriteLine("Daily Wage of " + employees[i].EmployeeName + " = " + employees[i].DailyWage);
            }
           

        }

        //UC5:Calculate Monthly Wage (20 Working Days)
        public void CalculateMonthlyWage()
    {
            int totalWage = 0;
            for (int i = 0; i < count; i++)
    {
        

        for (int day = 1; day <= WorkingDays; day++)
        {
            totalWage = totalWage + employees[i].DailyWage;
        }

        employees[i].MonthlyWage = totalWage;
    }

    Console.WriteLine("Monthly Wage Calculated Successfully and is: "+ totalWage);
}

        //UC6: Calculate Wage till total working hours or days reached
public void CalculateWageTillCondition()
{
    for (int i = 0; i < count; i++)
    {
        int totalHours = 0;
        int totalDays = 0;
        int totalWage = 0;

        while (totalDays < MaxWorkingDays && totalHours < MaxWorkingHours)
        {
            int empCheck = random.Next(0, 3);
            int hoursWorked = 0;

            switch (empCheck)
            {
                case 1: // Full Time
                    hoursWorked = FullDayHours;
                    break;

                case 2: // Part Time
                    hoursWorked = PartTimeHours;
                    break;

                default: // Absent
                    hoursWorked = 0;
                    break;
            }

            totalHours = totalHours + hoursWorked;
            totalWage = totalWage + (hoursWorked * WagePerHour);
            totalDays++;
        }

        employees[i].TotalWorkingHours = totalHours;
        employees[i].MonthlyWage = totalWage;
        Console.WriteLine("Wage Calculated Till Condition Reached. Total wage: "+totalWage);
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
