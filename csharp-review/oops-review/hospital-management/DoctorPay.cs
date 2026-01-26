using System;

public class DoctorPay: Doctor, IBill
{
	public double DailyWage;
	public int WorkingDays;

	public DoctorPay(string name, double wage, int days) : base(name) 
	{
		DailyWage = wage;
		WorkingDays = days;
			
	}

	public double DoctorWage() {
		return DailyWage * WorkingDays;
	}

	public double PatientBill() {
		return 0;
	}


}
