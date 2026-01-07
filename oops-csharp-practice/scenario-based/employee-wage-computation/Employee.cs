using System;

namespace Employee
{
    internal class Employee
    {
        private string employeeid;
        private string employeename;
        private string employeesalary;
        private string employeeattendance;   // UC1 Employee Attendance Check


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


        public override string ToString()
        {
            return "Employee ID : " + employeeid + "\nEmployee Name : " + employeename + "\nEmployee Salary : " + employeesalary + "\nEmployee Attendance : " + employeeattendance;
        }
    
    }
}
