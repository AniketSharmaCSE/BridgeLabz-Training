using System;

public abstract class Patient
{
    private int patientId;
    private string patientName;
    private int age;

    //sensitive data kept private
    private string diagnosis;

    public int PatientId
    {
        get 
        {
             return patientId; 
        }
        set
        {
             patientId = value; 
        }
    }

    public string PatientName
    {
        get
         {
             return patientName; 
        }
        set 
        { 
            patientName = value; 
        }
    }

    public int Age
    {
        get 
        {
             return age; 
        }
        set 
        {
             age = value;
        }
    }

    protected void SetDiagnosis(string diagnosisDetails)
    {
        diagnosis = diagnosisDetails;
    }

    protected string GetDiagnosis()
    {
        return diagnosis;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient Id: " + patientId);
        Console.WriteLine("Patient Name: " + patientName);
        Console.WriteLine("Age: " + age);
    }
}
