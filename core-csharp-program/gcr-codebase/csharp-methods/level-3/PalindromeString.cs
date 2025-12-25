using System;

public class PalindromeString
{
	//Method to check palindrome string
	static bool IsPalindrome(string text){
		int start=0;
		int end=text.Length-1;

		while(start<end){
			if(text[start]!=text[end]){
				return false;
			}
			start++;
			end--;
		}
		return true;
	}


	static void Main(string[] args)
	{
		//Take input from user
		Console.WriteLine("Enter string:");
		string text=Console.ReadLine();

		if(IsPalindrome(text)){
			Console.WriteLine("Palindrome");
		}
		else{
			Console.WriteLine("Not Palindrome");
		}
	}
}
