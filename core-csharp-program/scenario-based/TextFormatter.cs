/*using System;

public class TextFormatter
{
    // Method to format text
    static string Format(string text)
    {
        string formatted = "";
        bool SentenceStart = true;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            // Skip extra spaces 
            if (ch == ' ')
            {
                if (formatted.Length == 0 || formatted[formatted.Length - 1] == ' ')
                {
                    continue;
                }

                formatted += ' ';
                continue;
            }

            // Capitalize after punctuation
            if (SentenceStart && ch >= 'a' && ch <= 'z')
            {
                //Converted from lowercase to uppercase using ascii values
                ch = (char)(ch - 32);
                SentenceStart = false;
            }

            // Handle sentence-ending punctuation
            if (ch == '.' || ch == '?' || ch == '!' || ch == ',')
            {
                formatted += ch;
                SentenceStart = true;

                if (i + 1 < text.Length && text[i + 1] != ' ')
                {
                    formatted += ' ';
                }

                continue;
            }

            // Normal character
            formatted += ch;
        }

        // Remove trailing spaces
        if (formatted.Length > 0 && formatted[formatted.Length - 1] == ' ')
        {
            formatted = formatted.Substring(0, formatted.Length - 1);
        }

        return formatted;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text:");
        string text = Console.ReadLine();

        Console.WriteLine(Format(text));
    }
}
*/