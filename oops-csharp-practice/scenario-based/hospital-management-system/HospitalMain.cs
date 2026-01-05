using System;

class HospitalMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select patient type:");
        Console.WriteLine("1.InPatient");
        Console.WriteLine("2.OutPatient");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter patient name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Patient patient;

        if (choice == 1)
        {
            Console.WriteLine("Enter days admitted:");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter daily charge:");
            double charge = Convert.ToDouble(Console.ReadLine());

            patient = new InPatient(name, age, days, charge);
        }
        else
        {
            Console.WriteLine("Enter consultation fee:");
            double fee = Convert.ToDouble(Console.ReadLine());

            patient = new OutPatient(name, age, fee);
        }

        patient.DisplayInfo();
    }
}
