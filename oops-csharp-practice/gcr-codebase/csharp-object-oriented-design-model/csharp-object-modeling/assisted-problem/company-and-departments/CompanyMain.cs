using System;

public class CompanyMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter number of departments:");
        int deptCount = Convert.ToInt32(Console.ReadLine());


        Company company = new Company(companyName, deptCount);

        for (int i = 0; i < deptCount; i++)
        {
            Console.WriteLine("Enter department name:");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter number of employees:");
            int empCount = Convert.ToInt32(Console.ReadLine());

            Department dept = company.CreateDepartment(deptName, empCount);


            for (int j = 0; j < empCount; j++)
            {
                Console.WriteLine("Enter employee name:");
                string empName = Console.ReadLine();
                Console.WriteLine("Enter employee role:");
                string role = Console.ReadLine();


                dept.AddEmployee(empName, role);

            }

        }

        company.DisplayCompany();
        //Deleting company removes all departments and employees
        company.DeleteCompany();

    }
	
}
