using System;

public class UppercaseConversion
{
    //Method to convert text to uppercase using ASCII logic
    static string ConvertToUppercaseManually(string name)
    {
        string result = "";
        for (int i = 0; i < name.Length; i++)
        {
            char ch = name[i];
            //if character is lowercase alphabet
            if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
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

        string manualUpper = ConvertToUppercaseManually(name);
        string builtInUpper = name.ToUpper();
        bool areSame = CompareStrings(manualUpper, builtInUpper);

        Console.WriteLine("Uppercase using ASCII logic:");
        Console.WriteLine(manualUpper);
        Console.WriteLine("Uppercase using built-in method:");
        Console.WriteLine(builtInUpper);
		Console.WriteLine("Are both results same?");
        if (areSame)
        {
            Console.WriteLine("Yes");
        }
    }
}
