using System;

public class Company
{
    string companyName;
    Department[] departments;
    int deptIndex = 0;


    //Company owns departments completely
    public Company(string companyName, int departmentCount)
    {
        this.companyName = companyName;
        departments = new Department[departmentCount];
    }


    //Creates department as part of company
    public Department CreateDepartment(string name, int employeeCount)
    {
        Department dept = new Department(name, employeeCount);
        departments[deptIndex] = dept;
        deptIndex++;
        return dept;

    }


    //Displays entire company structure
    public void DisplayCompany()
    {
        Console.WriteLine("Company: " + companyName);
        for (int i = 0; i < deptIndex; i++)
        {
            departments[i].DisplayDepartment();
        
		}
    
	}


    //Simulates deletion of company and all its parts
    public void DeleteCompany()
    {
        departments = null;
        Console.WriteLine("Company deleted along with all departments and employees");
    }

}
