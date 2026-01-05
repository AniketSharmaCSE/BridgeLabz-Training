using System;

public class Hospital
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter hospital name:");
        Patient.HospitalName = Console.ReadLine();
        Console.WriteLine("Enter number of patients:");
        int count = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < count; i++)
        {

            Console.WriteLine("Enter patient name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ailment:");
            string ailment = Console.ReadLine();
            Console.WriteLine("Enter patient ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            Patient patient = new Patient(name, age, ailment, id);


            //Ensuring correct object type before display
            if (patient is Patient)
            {
                patient.ShowPatientDetails();

            }

        }

        Patient.GetTotalPatients();
    }
}
