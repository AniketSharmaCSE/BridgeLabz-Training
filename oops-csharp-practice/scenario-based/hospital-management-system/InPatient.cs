using System;

class InPatient : Patient, IPayable
{
    public int DaysAdmitted;
    public double DailyCharge;

    public InPatient(string name, int age, int days, double charge)
        : base(name, age)
    {
        DaysAdmitted = days;
        DailyCharge = charge;
    }

    public double CalculateBill()
    {
        return DaysAdmitted * DailyCharge;
    }

    //Override to display inpatient details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Patient Type: InPatient");
        Console.WriteLine("Total Bill: " + CalculateBill());
    }
}
