using System;

public class LeapYear
{
	//Method to check leap year
	static bool IsLeapYear(int year){
		//Conditions to check for leap year
		if(year>=1582){
			if((year%4==0 && year%100!=0) || year%400==0){
				return true;
			}
		}
		return false;
	}

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter year:");
		int year=Convert.ToInt32(Console.ReadLine());


		if(IsLeapYear(year)){
			Console.WriteLine("Leap Year");
		}
		else{
			Console.WriteLine("Not a Leap Year");
		}
	}
}
