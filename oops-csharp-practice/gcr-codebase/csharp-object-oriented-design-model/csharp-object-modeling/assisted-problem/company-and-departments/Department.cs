using System;

public class Department
{
    string departmentName;
    Employee[] employees;
    int empIndex = 0;


    //Department created only through Company
    public Department(string departmentName, int employeeCount)
    {
        this.departmentName = departmentName;
        employees = new Employee[employeeCount];

    }


    //Adds employee under this department
    public void AddEmployee(string name, string role)
    {
        if (empIndex < employees.Length){
            employees[empIndex] = new Employee(name, role);
            empIndex++;
        
		}
    
	}

    
	//Displays department and its employees
    public void DisplayDepartment()
    {
        Console.WriteLine("Department: " + departmentName);


        for (int i = 0; i < empIndex; i++)
        {
            employees[i].DisplayEmployee();
        }

    }
}
