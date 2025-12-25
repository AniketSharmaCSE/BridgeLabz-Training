using System;

public class SmallestLargest
{
	//Method to do find smallest and largest number
	static int[] FindSmallestAndLargest(int a,int b,int c){
		//define variables for smallest and largest assuming a for both
		int smallest=a;
		int largest=a;
		if(b<smallest){
			smallest=b;
		}
		if(c<smallest){
			smallest=c;
		}

		if(b>largest){
			largest=b;
		}
		if(c>largest){
			largest=c;
		}
		return new int[]{smallest,largest};
	}

	
	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter first number:");
		int a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second number:");
		int b=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter third number:");
		int c=Convert.ToInt32(Console.ReadLine());

		//Call method
		int[] result=FindSmallestAndLargest(a,b,c);

		//Print result
		Console.WriteLine("Smallest = "+result[0]);
		Console.WriteLine("Largest = "+result[1]);
	}
}
