using System;

public class ReverseString
{
	
    //Method to reverse string manually
    static string ReverseManually(string word)
    {
        string reversed = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed = reversed + word[i];
        }

        return reversed;
    }


    static void Main(string[] args)
    {
		//ask user for string
        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();
        string result = ReverseManually(word);
        Console.WriteLine("Reversed string:");
        Console.WriteLine(result);
    }
}
