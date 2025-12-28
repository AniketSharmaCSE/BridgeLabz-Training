using System;

public class LowerCaseConversion
{
    //Method to convert text to lowercase using ASCII logic
    static string ConvertToLowercaseManually(string name)
    {
		
        string result = "";
        for (int i = 0; i < name.Length; i++)
        {
            char ch = name[i];
            //if character is uppercase alphabet
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
            result = result + ch;
        
		}
        return result;
    }


    //Method to compare two strings
    static bool CompareStrings(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                return false;
            }
        }

        return true;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        string manualLower = ConvertToLowercaseManually(name);
        string builtInLower = name.ToLower();
        bool areSame = CompareStrings(manualLower, builtInLower);

        Console.WriteLine("Lowercase using ASCII logic:");
        Console.WriteLine(manualLower);
        Console.WriteLine("Lowercase using built-in method:");
        Console.WriteLine(builtInLower);
        Console.WriteLine("Are both results same?");
        if (areSame)
        {
            Console.WriteLine("Yes");
        }
    }
}
