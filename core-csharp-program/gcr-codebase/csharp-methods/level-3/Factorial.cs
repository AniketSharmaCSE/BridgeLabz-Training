using System;

public class Factorial
{
	//Method to calculate factorial using recursion
	static int FindFactorial(int number){
		if(number==0){
			return 1;
		}
		else{
			return number*FindFactorial(number-1);
			
		}
	}


	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter number: ");
		int number=Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Factorial = "+FindFactorial(number));
	}
}
