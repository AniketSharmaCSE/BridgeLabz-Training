using System;

public class PalindromeCheck
{
	
    //Method to check palindrome
    static bool IsPalindrome(string word)
    {
        int start = 0;
        int end = word.Length - 1;
        while (start<end)
        {
			
            if (word[start] != word[end])
            {
      			return false;
            }
            start++;
            end--;

        }

        return true;
    }
	
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();
        if (IsPalindrome(word))
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not a palindrome");
        }
    }
}
