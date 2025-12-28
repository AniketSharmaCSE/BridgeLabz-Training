using System;

public class ReplaceWord
{
	
    //Method to replace a word in a sentence
    static string ReplaceWordManually(string sentence, string oldWord, string newWord)
    {
        string result = "";
        string currentWord = "";


        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                currentWord = currentWord + sentence[i];

            }
            else
            {
                //check if current word matches word to replace
                if (currentWord == oldWord)
                {
                    result = result + newWord;
                }

                else
                {
                    result = result + currentWord;
                }
                result = result + " ";
                currentWord = "";
            }
        }

        //handle last word
        if (currentWord == oldWord)
        {
            result = result + newWord;
        }
        else
        {
            result = result + currentWord;
        }

        return result;
    }
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter sentence: ");
        string sentence = Console.ReadLine();
        Console.WriteLine("Enter word to replace: ");
        string oldWord = Console.ReadLine();
        Console.WriteLine("Enter new word: ");
        string newWord = Console.ReadLine();
		
        string output = ReplaceWordManually(sentence, oldWord, newWord);

        Console.WriteLine("Modified sentence:");
        Console.WriteLine(output);
    }
}
