using System;

public class SpringSeason
{	
	//Method to check if spring season
	static bool IsSpringSeason(int month,int day){
		if{
			((month==3 && day>=20) || (month>3 && month<6) || (month==6 && day<=20))
			return true;
		}
		else{
			return false;
		}
	}


	static void Main(string[] args)
	{
		//Take month and day from user
		Console.WriteLine("Enter month: ");
		int month=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter day :");
		int day=Convert.ToInt32(Console.ReadLine());

		//Check using the method
		bool result=IsSpringSeason(month,day);

		//Print output
		if{(result)
			Console.WriteLine("Its a Spring Season");
		}
		else{
			Console.WriteLine("Not a Spring Season");
		}
	}
}
