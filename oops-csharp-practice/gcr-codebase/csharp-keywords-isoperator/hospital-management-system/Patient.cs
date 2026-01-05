using System;

public class Patient
{
    //Hospital name common to all patients
    public static string HospitalName = "City Hospital";

    static int totalPatients = 0;
    string name;
    int age;
    string ailment;
    readonly int patientID;


    //Constructor sets patient information
    public Patient(string name, int age, string ailment, int patientID)
    {
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        this.patientID = patientID;
		totalPatients++;
    
	}


    //Displays patient information
    public void ShowPatientDetails()
    {
        Console.WriteLine("Hospital: " + HospitalName);
        Console.WriteLine("Patient ID: " + patientID);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Ailment: " + ailment);

    }


    //Returns total admitted patients
    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients Admitted: " + totalPatients);

    }

}
