using System;

class UniversityMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter student name:");
        Student student = new Student(Console.ReadLine());
        Console.WriteLine("Enter professor name:");
        Professor professor = new Professor(Console.ReadLine());
        Console.WriteLine("Enter course name:");
        Course course = new Course(Console.ReadLine());

        student.EnrollCourse(course);
        professor.AssignProfessor(course);
    }
}
