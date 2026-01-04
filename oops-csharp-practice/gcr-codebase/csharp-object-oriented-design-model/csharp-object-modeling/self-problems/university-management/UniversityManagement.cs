using System;

class UniversityManagement
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter university name:");
        string uniName = Console.ReadLine();
        Console.WriteLine("Enter number of departments:");
        int deptCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of faculty members:");
        int facultyCount = Convert.ToInt32(Console.ReadLine());

        University university = new University(uniName, deptCount, facultyCount);

        for (int i = 0; i < deptCount; i++)
        {
            Console.WriteLine("Enter department name:");
            university.Departments[i] = new Department(Console.ReadLine());
        }

        Faculty independentFaculty = null;

        for (int i = 0; i < facultyCount; i++)
        {
            Console.WriteLine("Enter faculty name:");
            Faculty f = new Faculty(Console.ReadLine());
            university.Faculties[i] = f;

            if (i == 0)
            {
                independentFaculty = f;
            }
        }

        university.Display();

        Console.WriteLine("University deleted");
        university = null;

        //Faculty exists independently
        independentFaculty.Display();
    }
}
