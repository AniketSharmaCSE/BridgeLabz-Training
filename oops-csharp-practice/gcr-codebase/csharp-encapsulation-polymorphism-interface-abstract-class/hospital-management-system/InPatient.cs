using System;

public class InPatient : Patient, IMedicalRecord
{
    private int numberOfDaysAdmitted;
    private double dailyCharge;

    public InPatient(int numberOfDaysAdmitted, double dailyCharge)
    {
        this.numberOfDaysAdmitted = numberOfDaysAdmitted;
        this.dailyCharge = dailyCharge;
    }

    public override double CalculateBill()
    {
        return numberOfDaysAdmitted * dailyCharge;
    }

    public void AddRecord(string diagnosisDetails)
    {
        //store diagnosis securely
        SetDiagnosis(diagnosisDetails);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Diagnosis: " + GetDiagnosis());
    }
}
