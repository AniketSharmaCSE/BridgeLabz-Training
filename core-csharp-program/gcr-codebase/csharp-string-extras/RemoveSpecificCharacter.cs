using System;

public class RemoveSpecificCharacter
{
	
    //Method to remove all occurrences of a character
    static string RemoveCharacter(string text, char removeChar)
    {
        string result = "";
		
        //build new string by skipping given character
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != removeChar)
            {
                result = result + text[i];
            }
        }
        return result;
    }
	
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter character to remove: ");
        char removeChar = Console.ReadLine()[0];

        string output = RemoveCharacter(text, removeChar);
        Console.WriteLine("Modified string:");
        Console.WriteLine(output);
    }
}
