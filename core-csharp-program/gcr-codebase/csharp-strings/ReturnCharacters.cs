using System;

public class ReturnCharacters
{
    //Method to return characters 
    static char[] GetCharactersManually(string text)
    {
        int length = text.Length;
        char[] result = new char[length];
		
        for (int i = 0; i < length; i++)
        {
            result[i] = text[i];
        }

        return result;
    }
	

    //Method to compare arrays
    static bool CompareCharArrays(char[] arr1, char[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();

        if (text == null)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        char[] manualChars = GetCharactersManually(text);
        char[] builtInChars = text.ToCharArray();

        bool areSame = CompareCharArrays(manualChars, builtInChars);
        Console.WriteLine("Characters returned manually:");
        for (int i = 0; i < manualChars.Length; i++)
        {
            Console.Write(manualChars[i] + " ");
        }
        Console.WriteLine("Are both character arrays same?");
        if (areSame)
        {
            Console.WriteLine("Yes");
        }
    }
}
