using System;

public class SchoolMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter school name:");
        School school = new School(Console.ReadLine(), 5);

        Console.WriteLine("Enter number of courses:");
        int courseCount = Convert.ToInt32(Console.ReadLine());
        Course[] courses = new Course[courseCount];

        for (int i = 0; i < courseCount; i++)
        {
            Console.WriteLine("Enter course name:");
            courses[i] = new Course(Console.ReadLine(), 5);
        }

        Console.WriteLine("Enter number of students:");
        int studentCount = Convert.ToInt32(Console.ReadLine());

        Student[] students = new Student[studentCount];

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine("Enter student name:");
            students[i] = new Student(Console.ReadLine(), courseCount);
            school.AddStudent(students[i]);

            Console.WriteLine("How many courses to enroll?");
            int enrollCount = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < enrollCount; j++)
            {
                Console.WriteLine("Choose course index (0 to " + (courseCount - 1) + "):");
                int index = Convert.ToInt32(Console.ReadLine());
                students[i].EnrollCourse(courses[index]);
            }
        }

        Console.WriteLine();
        school.DisplayStudents();

        Console.WriteLine();
        for (int i = 0; i < studentCount; i++)
        {
            students[i].DisplayCourses();
            Console.WriteLine();
        }

        Console.WriteLine();
        for (int i = 0; i < courseCount; i++)
        {
            courses[i].DisplayStudents();
            Console.WriteLine();
        }
    }
}
