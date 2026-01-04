using System;

class SchoolRoles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select role:");
        Console.WriteLine("1.Teacher");
        Console.WriteLine("2.Student");
        Console.WriteLine("3.Staff");

        int choice = Convert.ToInt32(Console.ReadLine());

        Person person;

        if (choice == 1)
        {
            Console.WriteLine("Enter subject:");
            string subject = Console.ReadLine();

            person = new Teacher(name, age, subject);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter grade:");
            string grade = Console.ReadLine();

            person = new Student(name, age, grade);
        }
        else
        {
            Console.WriteLine("Enter department:");
            string department = Console.ReadLine();

            person = new Staff(name, age, department);
        }

        person.DisplayRole();
    }
}
