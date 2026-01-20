using System;

class ScreeningSystem
{
    static void Main(string[] args)
    {
        Resume<SoftwareEngineer> seResumes = new Resume<SoftwareEngineer>();
        Resume<DataScientist> dsResumes = new Resume<DataScientist>();

        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\n--- Resume Screening System ---");
            Console.WriteLine("1. Add Software Engineer Resume");
            Console.WriteLine("2. Add Data Scientist Resume");
            Console.WriteLine("3. Screen All Resumes");
            Console.WriteLine("4. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter candidate name:");
                    string seName = Console.ReadLine();
                    seResumes.AddResume(new SoftwareEngineer(seName));
                    break;

                case 2:
                    Console.WriteLine("Enter candidate name:");
                    string dsName = Console.ReadLine();
                    dsResumes.AddResume(new DataScientist(dsName));
                    break;

                case 3:
                    Console.WriteLine("\nSoftware Engineer Resumes:");
                    seResumes.ProcessResumes();

                    Console.WriteLine("\nData Scientist Resumes:");
                    dsResumes.ProcessResumes();
                    break;

                case 4:
                    Console.WriteLine("Exiting Resume Screening System");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
