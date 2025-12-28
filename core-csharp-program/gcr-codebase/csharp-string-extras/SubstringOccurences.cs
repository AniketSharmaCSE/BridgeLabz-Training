using System;

public class SubstringOccurrences
{
    //Method to count substring occurrences
    static int CountOccurrences(string text, string sub)
    {
        int count = 0;
        for (int i = 0; i <= text.Length - sub.Length; i++)
        {
            int j = 0;
            while (j < sub.Length && text[i + j] == sub[j])
            {
                j++;
            }


            if (j == sub.Length)
            {
                count++;
            }
        }
        return count;
    }
	
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter substring: ");
        string sub = Console.ReadLine();

        int result = CountOccurrences(text, sub);
        Console.WriteLine("Occurrences: " + result);
    }
}
