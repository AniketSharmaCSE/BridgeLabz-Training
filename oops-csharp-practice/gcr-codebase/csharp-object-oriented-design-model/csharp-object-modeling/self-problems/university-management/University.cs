using System;

class University
{
    public string Name;
    public Department[] Departments;
    public Faculty[] Faculties;

    public University(string name, int deptCount, int facultyCount)
    {
        Name = name;
        Departments = new Department[deptCount];
        Faculties = new Faculty[facultyCount];
    }


    //Composition:departments depend on university
    public void Display()
    {
        Console.WriteLine("University: " + Name);

        Console.WriteLine("Departments:");
        for (int i = 0; i < Departments.Length; i++)
        {
            Departments[i].Display();
        }

        Console.WriteLine("Faculties:");
        for (int i = 0; i < Faculties.Length; i++)
        {
            Faculties[i].Display();
        }
    }
}
