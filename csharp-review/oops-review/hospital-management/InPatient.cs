using System;

public class InPateint : Patient, IBill
{
	public int Totaldays;
	public double PerDaycharge;

	public Inpatient(string name, int age, int days, double charge): base(name,age) { 
		TotalDays = days;
		PerDayCharge = charge;
	}

	public double PatientBill() {
			return TotalDays * PerDayCharge;		
	}

public override void DisplayInfo() {
	base.DisplayInfo();
	Console.WriteLine("Total bill is: " + PatientBill());
	} 

}
