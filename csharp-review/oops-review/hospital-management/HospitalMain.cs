using System;

public class HospitalMain
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Ente Patient type: 1. InPatient 2. OutPatient");
		int choice = ConvertTo.Int32(Console.Readline());

		IBill patient = null;
		Console.WriteLine("Enter Patient name: ");
		string name = Console.ReadLine();

		Console.WriteLine("Enter Patient's age: ");
		int age = ConvertTo.Int32(Console.ReadLine());

		if (choice == 1)
		{
			Console.WriteLine("Enter total days admitted: ");
			int days = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter per day charge");
			double charge = Convert.ToDouble(Console.ReadLine());

			patient = new InPatient(name, age, days, charge);
		}
		else if (choice == 2) {
			Console.WriteLine("Enter Consultaton fee: ");
			double fee = Convert.ToDouble(Console.ReadLine());

			patient = new OutPatient(name, age, fee);

		}
		Console.WriteLine("Pateint Details: ");
		(Patient)patient.DisplayInfo();

		Console.WriteLine("Doctor Details: ");
		Console.WriteLine("Enter Doctor's name: ");
		string DoctorName = Console.ReadLine();
		Console.WriteLine("Enter Daily Wage: ");
		double wage = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter working days: ");
		int WorkingDays = Convert.ToInt(Console.Readline());

		DoctorPay doctor = new DoctorPay(DoctorName, wage, WorkingDays);
		Console.WriteLine("Doctor Bill: " + doctor.CalculateBill());



	}
}
