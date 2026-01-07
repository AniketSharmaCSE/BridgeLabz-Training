using System;

namespace Employee
{
    internal class Employee
    {
        private string employeeid;
        private string employeename;
        private string employeesalary;
        private string employeeattendance;   // UC1 Employee Attendance Check
        private int dailywage; //UC2 Daily Wage

        public string EmployeeId
        {
            get
            {
                return employeeid;
            }
            set
            {
                employeeid = value;
            }
        }


        public string EmployeeName
        {
            get
            {
                return employeename;
            }
            set
            {
                employeename = value;
            }
        }


        public string EmployeeSalary
        {
            get
            {
                return employeesalary;
            }
            set
            {
                employeesalary = value;
            }
        }


        public string EmployeeAttendance
        {
            get
            {
                return employeeattendance;
            }
            set
            {
                employeeattendance = value;
            }
        }
       
        // UC2 Daily Wage
        public int DailyWage
        {
            get 
            { 
                return dailywage;
            }
            set 
            {
                dailywage = value; 
            }
        }



        public override string ToString()
        {
            return "Employee ID : " + employeeid + "\nEmployee Name : " + employeename + "\nEmployee Salary : " + employeesalary + "\nEmployee Attendance : " + employeeattendance + "\nDaily Wage : " + dailywage;
        }
    
    }
}
