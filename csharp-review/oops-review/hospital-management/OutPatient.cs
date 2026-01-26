using System;

public class OutPatient: Patient, IBill
{
	public double ConsultationFee;

	public OutPatient(string name, int age, double fee) : base(name, age)
	{
		ConsultationFee = fee;
	}

	public double CalculateBill() {
		return ConsultationFee;
	}

    public override void DisplayInfo()
    {
        base.DisplayInfo();
		Console.WriteLine("Patient Type: " + OutPatient);
        Console.WriteLine("Total bill is: " + PatientBill());
    }

}
