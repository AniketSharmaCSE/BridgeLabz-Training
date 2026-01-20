using System;

class University
{
    static void Main(string[] args)
    {
        Course<ExamCourse> examCourses = new Course<ExamCourse>();
        Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();

        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\n--- University Course Management ---");
            Console.WriteLine("1. Add Exam Course");
            Console.WriteLine("2. Add Assignment Course");
            Console.WriteLine("3. Display All Courses");
            Console.WriteLine("4. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter exam course name:");
                    string examName = Console.ReadLine();
                    examCourses.AddCourse(new ExamCourse(examName));
                    break;

                case 2:
                    Console.WriteLine("Enter assignment course name:");
                    string assignmentName = Console.ReadLine();
                    assignmentCourses.AddCourse(new AssignmentCourse(assignmentName));
                    break;

                case 3:
                    Console.WriteLine("\nExam Based Courses:");
                    examCourses.DisplayCourses();

                    Console.WriteLine("\nAssignment Based Courses:");
                    assignmentCourses.DisplayCourses();
                    break;

                case 4:
                    Console.WriteLine("Exiting system");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
