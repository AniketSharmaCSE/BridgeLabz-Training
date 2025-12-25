using System;

public class QuotientRemainder
{
	//Define method to find remainder and quotient
	static int[] FindRemainderAndQuotient(int number,int divisor){
		int quotient=number/divisor;
		int remainder=number%divisor;
		return new int[]{quotient,remainder};
	}

	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter divisor:");
		int divisor=Convert.ToInt32(Console.ReadLine());


		//Call method
		int[] result=FindRemainderAndQuotient(number,divisor);


		//Print result
		Console.WriteLine("Quotient = "+result[0]);
		Console.WriteLine("Remainder = "+result[1]);
	}
}
