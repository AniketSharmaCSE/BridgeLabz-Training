using System;

public class VoteEligibilty
{
    static void Main(string[] args)
    {
		//Initialise an array of length 10
        int[] age = new int[10];
		
		//For loop to input values for the array
        for (int i = 0; i < age.Length; i++)
        {
            Console.WriteLine(i + ". Enter age: ");

            age[i] = Convert.ToInt32(Console.ReadLine());
        }
		//for loop to traverse through array and check if eligible or not
        for (int j = 0; j < age.Length; j++)
        {
            if (age[j] <= 0)
            {
                Console.WriteLine("Enter a positive age!");
            }
            else if (age[j] < 18)
            {
                Console.WriteLine("The student with age " + age[j] + " cannot vote");
            }
            else
            {
                Console.WriteLine("The student with age " + age[j] + " can vote");
            }
        }
    }
}