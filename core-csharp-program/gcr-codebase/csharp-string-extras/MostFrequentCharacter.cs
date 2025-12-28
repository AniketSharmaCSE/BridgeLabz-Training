using System;

public class MostFrequentCharacter
{
	
    //Method to find most frequent character in a string
    static char FindMostFrequent(string text)
    {
        int maxCount = 0;
        char mostFrequent = text[0];

        //pick one character at a time
        for (int i = 0; i < text.Length; i++)
        {
            int count = 0;
            //count occurrences of current character
            for (int j = 0; j < text.Length; j++)
            {
                if (text[i] == text[j])
                {
                    count++;
                }
            }
            //update max count and character
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = text[i];
            }
        }

        return mostFrequent;
    }




    static void Main(string[] args)
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        char result = FindMostFrequent(text);

        Console.WriteLine("Most frequent character: " + result);
    }
}
