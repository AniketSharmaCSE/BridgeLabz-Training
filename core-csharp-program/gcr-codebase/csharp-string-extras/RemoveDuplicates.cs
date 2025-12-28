using System;

public class RemoveDuplicates
{
	
    //Method to remove duplicate characters
    static string RemoveDuplicateCharacters(string word)
    {
        string result = "";
        for (int i = 0; i < word.Length; i++)
        {
            char ch = word[i];
            bool exists = false;
            for (int j = 0; j < result.Length; j++)
            {
				
                if (result[j] == ch)
                {
                    exists = true;
      				break;
                }
            }

            if (!exists)
            {
                result = result + ch;
            }
        }
        return result;
    }
	
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();
        
		string output = RemoveDuplicateCharacters(word);
        Console.WriteLine("Modified string:");
        Console.WriteLine(output);
    }
}
