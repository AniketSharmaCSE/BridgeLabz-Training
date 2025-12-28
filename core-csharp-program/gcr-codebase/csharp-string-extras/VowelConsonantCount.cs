using System;

public class VowelConsonantCount
{
    //Method to count vowels and consonants
    static void CountVowelsAndConsonants(string word)
    {
        int vowels = 0;
        int consonants = 0;

        for (int i = 0; i < word.Length; i++)
        {
            char ch = word[i];
				//Condition to check if vowel
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            
        }
        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();
        CountVowelsAndConsonants(word);
    }
}
