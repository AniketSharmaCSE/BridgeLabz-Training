using System;

public class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;

    public OutPatient(double consultationFee)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
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
