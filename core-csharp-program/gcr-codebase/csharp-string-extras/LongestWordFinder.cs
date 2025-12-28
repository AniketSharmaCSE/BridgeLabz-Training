using System;

public class LongestWordFinder
{
    //Method to find longest word
    static string FindLongestWord(string sentence)
    {
        string currentWord = "";
        string longestWord = "";
		

        for (int i = 0; i < sentence.Length; i++)
        {
        
		if (sentence[i] != ' ')
            {
                currentWord = currentWord + sentence[i];
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
				
                currentWord = "";
            }
        }
		

        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }

        return longestWord;
    }
	
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter sentence: ");
        string sentence = Console.ReadLine();

        string longest = FindLongestWord(sentence);
        Console.WriteLine("Longest word:");
        Console.WriteLine(longest);
    }
}
