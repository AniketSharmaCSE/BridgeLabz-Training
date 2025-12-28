using System;

public class SubString
{
    //Method to manually create substring using loop
    static string ManualSubstring(string str, int start, int end)
    {
        string result = ""; 
        for (int i = start; i < end; i++)
        {
            result = result + str[i];
        }

        return result;
    }

    //Method to compare two strings character by character
    static bool CompareStrings(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        //compare each character
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
        Console.WriteLine("Enter your text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter starting index: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter end index: ");
        int end = Convert.ToInt32(Console.ReadLine());

        // create substring manually
        string manualSub = ManualSubstring(text, start, end);

        // create substring using built-in method
        string builtInSub = text.Substring(start, end - start);

        // compare both substrings
        bool areEqual = CompareStrings(manualSub, builtInSub);

        Console.WriteLine("Manually made substring: ");
        Console.WriteLine(manualSub);
        Console.WriteLine("Substring made using built-in function: ");
        Console.WriteLine(builtInSub);

        Console.WriteLine("Are both substring same?");
        if (areEqual)
        {
            Console.WriteLine("Yes");
        }
    }
}
