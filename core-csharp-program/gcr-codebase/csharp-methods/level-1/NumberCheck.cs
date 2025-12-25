using System;

public class NumberCheck
{
	//Method to check number
	static int CheckNumber(int number){
		if(number>0){
		return 1;
		}
		else if(number<0){
		return -1;
		}
		else{
		return 0;
		}
	}


	static void Main(string[] args)
	{
		//Ask user to enter number
		Console.WriteLine("Enter a number:");
		int number=Convert.ToInt32(Console.ReadLine());
		//Call method to check number
		int result=CheckNumber(number);

		//Print result
		Console.WriteLine("Result = "+result);
	}
}
