using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter doctor name:");
        Doctor doctor = new Doctor(Console.ReadLine());
        Console.WriteLine("Enter number of patients:");
        int count = Convert.ToInt32(Console.ReadLine());

        Patient[] patients = new Patient[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter patient name:");
            patients[i] = new Patient(Console.ReadLine());
        }


        for (int i = 0; i < count; i++)
        {
            doctor.Consult(patients[i]);
        }
    }
}
