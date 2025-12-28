using System;

public class WordLengthFinder
{
    //Method to calculate length of a Word without using Length
    static int GetWordLength(string Word)
    {
        int count = 0;
        foreach (char ch in Word)
        {
            count++;
        }
        return count;
    }



    //Method to split Word into Words without using Split
    static string[,] SplitWordsAndLengths(string Word)
    {
        string currentWord = "";
        int WordCount = 0;
        //count number of Words
        for (int i = 0; i < Word.Length; i++)
        {
            if (Word[i] == ' ')
            {
                WordCount++;
            }
        }

        WordCount = WordCount +1;
        string[,] result = new string[WordCount, 2];
        int index = 0;

        for (int i = 0; i < Word.Length; i++)
        {
            if (Word[i] != ' ')
            {
                currentWord = currentWord + Word[i];
            }
            else
            {
                result[index, 0] = currentWord;
                result[index, 1] = GetWordLength(currentWord).ToString();
                index++;
                currentWord = "";
            }
        }

        //store last Word
        result[index, 0] = currentWord;
        result[index, 1] = GetWordLength(currentWord).ToString();
        return result;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Enter Word: ");
        string Word = Console.ReadLine();
        string[,] Words = SplitWordsAndLengths(Word);

        Console.WriteLine("Word and its length:");
        for (int i = 0; i < Words.GetLength(0); i++)
        {
            Console.WriteLine(Words[i, 0] + " : " + Words[i, 1]);
        }
    }
}
