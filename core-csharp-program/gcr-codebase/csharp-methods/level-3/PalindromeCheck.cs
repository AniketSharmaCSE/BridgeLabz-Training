using System;

public class PalindromeCheck
{
	//Method to reverse a number
	static int ReverseNumber(int number){
		int rev=0;

		while(number!=0){
			rev=rev*10+(number%10);
			number/=10;
		}
		return rev;
	}

	//Method to check palindrome
	static bool IsPalindrome(int number){
		int rev=ReverseNumber(number);
		if(rev==number){
			return true;
		}
		else{
			return false;
		}
	}

	//main method
	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter number:");
		int number=Convert.ToInt32(Console.ReadLine());

		int reversed=ReverseNumber(number);
		Console.WriteLine("Reverse = "+reversed);

		if(IsPalindrome(number)){
			Console.WriteLine("Palindrome");
		}
		else{
			Console.WriteLine("Not Palindrome");
		}
	}
}
