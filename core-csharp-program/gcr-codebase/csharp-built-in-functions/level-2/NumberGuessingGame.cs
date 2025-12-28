using System;

public class NumberGuessingGame
{
	
    //Method to generate a random guess within range
    static int GenerateGuess(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }



    //Method to get feedback from user
    static string GetUserFeedback()
    {
        Console.WriteLine("Is the guess high, low, or correct?");
        return Console.ReadLine();
    }


    //Method to update guessing range based on feedback
    static void UpdateRange(string feedback, int guess, ref int min, ref int max)
    {
        if (feedback == "high")
        {
            max = guess - 1;
        }
        else if (feedback == "low")
        {
            min = guess + 1;
        }
    }



    static void Main(string[] args)
    {
        int min = 1;
        int max = 100;
        bool guessedCorrectly = false;

        Console.WriteLine("Think of a number between 1 and 100.");

        while (!guessedCorrectly)
        {
            int guess = GenerateGuess(min, max);
            Console.WriteLine("Computer guess: " + guess);
			
            string feedback = GetUserFeedback();
            if (feedback == "correct")
            {
                Console.WriteLine("Number guessed correctly!");
                guessedCorrectly = true;
            }
            else
            {
                UpdateRange(feedback, guess, ref min, ref max);
            }
        }
    }
}
