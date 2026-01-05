using System;

class OutPatient : Patient, IPayable
{
    public double ConsultationFee;

    public OutPatient(string name, int age, double fee)
        : base(name, age)
    {
        ConsultationFee = fee;
    }

    public double CalculateBill()
    {
        return ConsultationFee;
    }

    //Override to display outpatient details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Patient Type: OutPatient");
        Console.WriteLine("Total Bill: " + CalculateBill());
    }
}
